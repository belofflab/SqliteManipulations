using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using SqliteManipulations.Models;

namespace SqliteManipulations
{
    internal class DatabaseConnection
    {
        private readonly string connectionString;
        public readonly string databasePath;
        //Суханов Сергей 16.02.2001 Чердынская 23 74 10 основная Тяжелая атлетика
        //Пирогов Юрий 5.12. 2003 Куйбышева 6 31 8 основная Футбол
        //Лебедева Света 16.06. 2005 Пушкина 37 65 6 специальная Вязание
        //Голдобин Сергей 23.05. 2008 Леонова 12 10 3 основная
        //Лыжи Ельшина Наташа 4.05. 2002 Чердынская 37 48 9 специальная Чтение
        //Суханова Наташа 20.12. 2006 Ленина 12 22 5 подготовительная Шитье
        //Петрова Света 02.04. 2002 Пушкина 37 3 9 основная Лыжи
        //Горина Оля 20.12. 2004 Свиязева 66 99 7 подготовительная Аэробика
        //Попов Михаил 7.05. 2007 Леонова 72 6 4 подготовительная
        //Сергеев Саша 30.11. 2009 Куйбышева 3 31 2 основная Каратэ
        //Павлова Елена 13.12. 2005 Пушкина 5 6 6 основная Аэробика
        //Емельянова Наташа 25.05. 2001 Попова 40 47 10 основная
        //Шитье Евдокимов Михаил 18.08. 2004 Чердынская 3 40 7 основная Футбол
        //Евсеева Елена 14.10. 2002 Ленина 14 82 9 основная
        //Суханова Света 29.07. 2000 Куйбышева 37 32 11 основная Аэробика
        public DatabaseConnection(string relativePath)
        {
            string projectDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            databasePath = Path.Combine(projectDirectory, relativePath);
            databasePath = Path.GetFullPath(databasePath);
            connectionString = $"Data Source={databasePath};Version=3;";
        }

        private void ExecuteNonQuery(string query, Action<SQLiteCommand> addParameters = null)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(query, connection);
            addParameters?.Invoke(command);
            command.ExecuteNonQuery();
        }
        public void QuickFill()
        {
            List<string> rawData = new List<string>
            {
                "true Суханов Сергей 16.02.2001 Чердынская 23 74 10 основная Тяжелая+атлетика",
                "true Пирогов Юрий 05.12.2003 Куйбышева 6 31 8 основная Футбол",
                "false Лебедева Света 16.06.2005 Пушкина 37 65 6 специальная Вязание",
                "true Голдобин Сергей 23.05.2008 Леонова 12 10 3 основная Лыжи",
                "false Ельшина Наташа 04.05.2002 Чердынская 37 48 9 специальная Чтение",
                "false Суханова Наташа 20.12.2006 Ленина 12 22 5 подготовительная Шитье",
                "false Петрова Света 02.04.2002 Пушкина 37 3 9 основная Лыжи",
                "false Горина Оля 20.12.2004 Свиязева 66 99 7 подготовительная Аэробика",
                "true Попов Михаил 07.05.2007 Леонова 72 6 4 подготовительная",
                "true Сергеев Саша 30.11.2009 Куйбышева 3 31 2 основная Каратэ",
                "false Павлова Елена 13.12.2005 Пушкина 5 6 6 основная Аэробика",
                "false Емельянова Наташа 25.05.2001 Попова 40 47 10 основная Шитье",
                "true Евдокимов Михаил 18.08.2004 Чердынская 3 40 7 основная Футбол",
                "false Евсеева Елена 14.10.2002 Ленина 14 82 9 основная",
                "false Суханова Света 29.07.2000 Куйбышева 37 32 11 основная Аэробика",
            };

            foreach (var line in rawData)
            {
                string[] data = line.Split(' ');
                const int SexIndex = 0;
                const int lastNameIndex = 1;
                const int firstNameIndex = 2;
                const int dateOfBirthIndex = 3;
                const int streetIndex = 4;
                const int houseIndex = 5;
                const int flatIndex = 6;
                const int classIndex = 7;
                const int uGroupIndex = 8;
                const int hobbyIndex = 9;
                const int eyeColorIndex = 10;

                int arrayLength = data.Length;

                Person person = new Person
                {
                    Sex = Boolean.Parse(data[SexIndex]),
                    LastName = data[lastNameIndex],
                    FirstName = data[firstNameIndex],
                    DateOfBirth = DateTime.Parse(data[dateOfBirthIndex]),
                    Street = data[streetIndex],
                    House = ParseInt(data[houseIndex]),
                    Flat = ParseInt(data[flatIndex]),
                    Class = data[classIndex],
                    UGroup = data[uGroupIndex],
                    Hobby = arrayLength > hobbyIndex ? data[hobbyIndex] : "",
                    EyeColor = arrayLength > eyeColorIndex ? data[eyeColorIndex] : ""
                };

                CreateOrUpdatePerson(person);
            }
        }

        private int ParseInt(string value)
        {
            int parsedValue;
            int.TryParse(value, out parsedValue);
            return parsedValue;
        }
        public void CreateTables()
        {
            ExecuteNonQuery("CREATE TABLE IF NOT EXISTS Person (" +
                "Id INTEGER PRIMARY KEY, " +
                "LastName TEXT, FirstName TEXT, " +
                "DateOfBirth DATETIME, Sex BOOLEAN, " +
                "Street TEXT, House INTEGER, Flat INTEGER," +
                "Class TEXT, UGroup TEXT, Hobby TEXT, EyeColor TEXT);");
        }
        public void CreateOrUpdatePerson(Person person)
        {
                if (person.Id != 0 && PersonExists(person.Id))
                {
                    ExecuteNonQuery(@"UPDATE Person
                              SET LastName = @LastName,
                                  FirstName = @FirstName,
                                  DateOfBirth = @DateOfBirth,
                                  Sex = @Sex,
                                  Street = @Street,
                                  House = @House,
                                  Flat = @Flat,
                                  Class = @Class,
                                  UGroup = @UGroup,
                                  Hobby = @Hobby,
                                  EyeColor = @EyeColor
                              WHERE Id = @Id;",
                        command =>
                        {
                            command.Parameters.AddWithValue("@LastName", person.LastName);
                            command.Parameters.AddWithValue("@FirstName", person.FirstName);
                            command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
                            command.Parameters.AddWithValue("@Sex", person.Sex);
                            command.Parameters.AddWithValue("@Street", person.Street);
                            command.Parameters.AddWithValue("@House", person.House);
                            command.Parameters.AddWithValue("@Flat", person.Flat);
                            command.Parameters.AddWithValue("@Class", person.Class);
                            command.Parameters.AddWithValue("@UGroup", person.UGroup);
                            command.Parameters.AddWithValue("@Hobby", person.Hobby);
                            command.Parameters.AddWithValue("@EyeColor", person.EyeColor);
                            command.Parameters.AddWithValue("@Id", person.Id);
                        });
                }
                else
                {
                    ExecuteNonQuery(@"INSERT INTO Person 
                              (LastName, FirstName, DateOfBirth, Sex, Street, House, Flat, Class, UGroup, Hobby, EyeColor) 
                              VALUES 
                              (@LastName, @FirstName, @DateOfBirth, @Sex, @Street, @House, @Flat, @Class, @UGroup, @Hobby, @EyeColor);",
                        command =>
                        {
                            command.Parameters.AddWithValue("@LastName", person.LastName);
                            command.Parameters.AddWithValue("@FirstName", person.FirstName);
                            command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
                            command.Parameters.AddWithValue("@Sex", person.Sex);
                            command.Parameters.AddWithValue("@Street", person.Street);
                            command.Parameters.AddWithValue("@House", person.House);
                            command.Parameters.AddWithValue("@Flat", person.Flat);
                            command.Parameters.AddWithValue("@Class", person.Class);
                            command.Parameters.AddWithValue("@UGroup", person.UGroup);
                            command.Parameters.AddWithValue("@Hobby", person.Hobby);
                            command.Parameters.AddWithValue("@EyeColor", person.EyeColor);
                        });
                }
        }
        public void DeletePerson(Person person)
        {
            ExecuteNonQuery("DELETE FROM Person WHERE id = @Id", command => {
                command.Parameters.AddWithValue("@Id", person.Id);
               }
            );
        }

        private bool PersonExists(int personId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT COUNT(*) FROM Person WHERE Id = {personId}", connection))
            {
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public List<Person> getPeoplesByFirstname(string personFirstname)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE Firstname = @Firstname", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Firstname", personFirstname);
                List<Person> people = new List<Person>();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }
        public List<Person> getPeoplesByLastname(string personLastname)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE Lastname = @Lastname", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Lastname", personLastname);
                List<Person> people = new List<Person>();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }
        public List<Person> getPeoplesByDob(string Year)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE DateOfBirth >= @DateStart AND DateOfBirth <= @DateEnd", connection))
            {
                connection.Open();
                DateTime parsedDateStart = new DateTime(int.Parse(Year), 1, 1);
                DateTime parsedDateEnd = new DateTime(int.Parse(Year), 12, 31);
                command.Parameters.AddWithValue("@DateStart", parsedDateStart);
                command.Parameters.AddWithValue("@DateEnd", parsedDateEnd);
                List<Person> people = new List<Person>();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }
        public List<Person> getPeoplesByDobNow(DateTime dateTime)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE strftime('%m-%d', DateOfBirth) = @CurrentDate", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CurrentDate", dateTime.ToString("MM-dd"));
                List<Person> people = new List<Person>();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }
                }
                return people;
            }
        }
        public List<Person> getPeoplesByMale()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE Sex = true", connection))
            {
                connection.Open();
                List<Person> people = new List<Person>();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }
        public List<Person> getPeoplesPushkina()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE Street = @Street", connection))
            {
                connection.Open();
                List<Person> people = new List<Person>();
                command.Parameters.AddWithValue("@Street", "Пушкина");
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }
        public List<Person> getPeoplesHardAdthlete()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE Hobby != @Hobby", connection))
            {
                connection.Open();
                List<Person> people = new List<Person>();
                command.Parameters.AddWithValue("@Hobby", "Тяжелая+атлетика");
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }
        public List<Person> getPeoplesHouseNumberThen50()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE House < 50", connection))
            {
                connection.Open();
                List<Person> people = new List<Person>();
                command.Parameters.AddWithValue("@Hobby", "Тяжелая+атлетика");
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }
        public List<Person> getPeoplesFlatNumberThen12()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE Flat < 12", connection))
            {
                connection.Open();
                List<Person> people = new List<Person>();
                command.Parameters.AddWithValue("@Hobby", "Тяжелая+атлетика");
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }

        public List<Person> getPeoplesHasNoHobby()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE Hobby = ''", connection))
            {
                connection.Open();
                List<Person> people = new List<Person>();
                command.Parameters.AddWithValue("@Hobby", "Тяжелая+атлетика");
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }

                }
                return people;
            }
        }

        public Person getPerson(int personId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM Person WHERE Id = @PersonId", connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@PersonId", personId);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        };
                    }
                }
                return null;
            }
        }


        public List<Person> GetPeoples()
        {
            List<Person> people = new List<Person>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Person", connection))
            {
                connection.Open();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        people.Add(new Person
                        {
                            Id = reader.GetInt32(0),
                            LastName = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            DateOfBirth = reader.GetDateTime(3),
                            Sex = reader.GetBoolean(4),
                            Street = reader.GetString(5),
                            House = reader.GetInt32(6),
                            Flat = reader.GetInt32(7),
                            Class = reader.GetString(8),
                            UGroup = reader.GetString(9),
                            Hobby = reader.GetString(10),
                            EyeColor = reader.GetString(11)
                        });
                    }
                }
            }

            return people;
        }
    }
}
