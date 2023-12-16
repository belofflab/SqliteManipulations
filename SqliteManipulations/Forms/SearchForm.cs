using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using SqliteManipulations.Models;

namespace SqliteManipulations.Forms
{
    public partial class SearchForm : Form
    {
        public string s;
        DatabaseConnection databaseConnection;
        List<Person> peoples;
        public SearchForm()
        {
            InitializeComponent();
            string relativePath = "database.db";
            databaseConnection = new DatabaseConnection(relativePath);
        }

    private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                switch (s)
                {
                    case "hobbynull":
                        peoples = databaseConnection.GetPeople("SELECT * FROM Person WHERE Hobby = ''");
                        break;
                    case "ft12":
                        peoples = databaseConnection.GetPeople("SELECT * FROM Person WHERE Flat < 12");
                        break;
                    case "ht50":
                        peoples = databaseConnection.GetPeople("SELECT * FROM Person WHERE House < 50");
                        break;
                    case "pushkina":
                        peoples = databaseConnection.GetPeople(
                        "SELECT* FROM Person WHERE Street = @Street", 
                        new SQLiteParameter[]
                            {
                                new SQLiteParameter("@Street", "Пушкина")
                            }
                        );
                        break;
                    case "nothathlete":
                        peoples = databaseConnection.GetPeople(
                            "SELECT * FROM Person WHERE Hobby != @Hobby",
                            new SQLiteParameter[]
                                {
                                    new SQLiteParameter("@Hobby", "Тяжелая+атлетика")
                                }
                            );
                        break;
                    case "firstname":
                        peoples = databaseConnection.GetPeople(
                            "SELECT * FROM Person WHERE Firstname = @Firstname",
                            new SQLiteParameter[]
                                {
                                    new SQLiteParameter("@Firstname", searchBox.Text)
                                }
                            );
                        break;
                    case "lastname":
                        peoples = databaseConnection.GetPeople(
                            "SELECT * FROM Person WHERE Lastname = @Lastname",
                            new SQLiteParameter[]
                                {
                                    new SQLiteParameter("@Lastname", searchBox.Text)
                                }
                            );
                        break;
                    case "dob":
                        DateTime parsedDateStart = new DateTime(int.Parse(searchBox.Text), 1, 1);
                        DateTime parsedDateEnd = new DateTime(int.Parse(searchBox.Text), 12, 31);
                        peoples = databaseConnection.GetPeople(
                            "SELECT * FROM Person WHERE DateOfBirth >= @DateStart AND DateOfBirth <= @DateEnd",
                            new SQLiteParameter[]
                                {
                                    new SQLiteParameter("@DateStart", parsedDateStart),
                                    new SQLiteParameter("@DateEnd", parsedDateEnd)
                                }
                            );
                        break;
                    case "dobnow":
                        peoples = databaseConnection.GetPeople(
                            "SELECT * FROM Person WHERE strftime('%m-%d', DateOfBirth) = @CurrentDate",
                            new SQLiteParameter[]
                                {
                                    new SQLiteParameter("@CurrentDate", DateTime.Now.ToString("MM-dd")),
                                }
                            );
                        break;
                    case "maleName":
                        peoples = databaseConnection.GetPeople("SELECT * FROM Person WHERE Sex = true");
                        break;
                }
                dataGridViewPersons.DataSource = peoples;
            } catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
    }
}
