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
        // Sex Lastname Firstname DOB Street House Flat class UGroup Hobby 
        // true Суханов Сергей 16.02.2001 Чердынская 23 74 10 основная Тяжелая+атлетика
        // true Пирогов Юрий 5.12.2003 Куйбышева 6 31 8 основная Футбол
        // false Лебедева Света 16.06.2005 Пушкина 37 65 6 специальная Вязание
        // true Голдобин Сергей 23.05.2008 Леонова 12 10 3 основная
        // false Лыжи Ельшина Наташа 4.05.2002 Чердынская 37 48 9 специальная Чтение
        // false Суханова Наташа 20.12.2006 Ленина 12 22 5 подготовительная Шитье
        // false Петрова Света 02.04.2002 Пушкина 37 3 9 основная Лыжи
        // false Горина Оля 20.12.2004 Свиязева 66 99 7 подготовительная Аэробика
        // true Попов Михаил 7.05.2007 Леонова 72 6 4 подготовительная
        // true Сергеев Саша 30.11.2009 Куйбышева 3 31 2 основная Каратэ
        // false Павлова Елена 13.12.2005 Пушкина 5 6 6 основная Аэробика
        // false Емельянова Наташа 25.05.2001 Попова 40 47 10 основная
        // true Шитье Евдокимов Михаил 18.08.2004 Чердынская 3 40 7 основная Футбол
        // false Евсеева Елена 14.10.2002 Ленина 14 82 9 основная
        // false Суханова Света 29.07.2000 Куйбышева 37 32 11 основная Аэробика
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
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        public List<Person> GetPeople(string commandText = "SELECT * FROM Person", SQLiteParameter[] sQLiteParameters = null)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
            {
                connection.Open();
                if (sQLiteParameters != null) {
                    command.Parameters.AddRange(sQLiteParameters);
                }
                List<Person> People = new List<Person>();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        People.Add(new Person
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
                return People;
            }
        }
    }
}
