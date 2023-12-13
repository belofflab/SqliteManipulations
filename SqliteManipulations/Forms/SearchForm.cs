using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        peoples = databaseConnection.getPeoplesHasNoHobby();
                        break;
                    case "ft12":
                        peoples = databaseConnection.getPeoplesFlatNumberThen12();
                        break;
                    case "ht50":
                        peoples = databaseConnection.getPeoplesHouseNumberThen50();
                        break;
                    case "pushkina":
                        peoples = databaseConnection.getPeoplesPushkina();
                        break;
                    case "nothathlete":
                        peoples = databaseConnection.getPeoplesHardAdthlete();
                        break;
                    case "firstname":
                        peoples = databaseConnection.getPeoplesByFirstname(textBoxLastname.Text);
                        break;
                    case "lastname":
                        peoples = databaseConnection.getPeoplesByLastname(textBoxLastname.Text);
                        break;
                    case "dob":
                        peoples = databaseConnection.getPeoplesByDob(textBoxLastname.Text);
                        break;
                    case "dobnow":
                        peoples = databaseConnection.getPeoplesByDobNow(DateTime.Now);
                        break;
                    case "maleName":
                        peoples = databaseConnection.getPeoplesByMale();
                        break;
                }
                dataGridViewPersons.DataSource = peoples;
            } catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
    }
}
