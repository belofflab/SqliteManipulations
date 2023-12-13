using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using SqliteManipulations.Models;
using SqliteManipulations.Forms;

namespace SqliteManipulations
{
    public partial class MainForm : Form
    {
        private readonly DatabaseConnection databaseConnection;
        public MainForm()
        {
            InitializeComponent();
            string relativePath = "database.db";
            databaseConnection = new DatabaseConnection(relativePath);
            if (!File.Exists(relativePath))
            {
                SQLiteConnection.CreateFile(databaseConnection.databasePath);
            }
            databaseConnection.CreateTables();
            dataGridViewPersons.DataSource = databaseConnection.GetPeoples();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Forms.AddOrChangePersonForm addPersonForm = new Forms.AddOrChangePersonForm())
            {
                if (addPersonForm.ShowDialog() == DialogResult.OK)
                {
                    databaseConnection.CreateOrUpdatePerson(addPersonForm.person);
                    dataGridViewPersons.DataSource = databaseConnection.GetPeoples();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersons.SelectedRows.Count > 0 || dataGridViewPersons.SelectedCells.Count > 0)
            {
                var uniqueRowIndices = dataGridViewPersons.SelectedCells
                    .Cast<DataGridViewCell>()
                    .Select(cell => cell.RowIndex)
                    .Distinct();

                foreach (int rowIndex in uniqueRowIndices)
                {
                    Person selectedPerson = dataGridViewPersons.Rows[rowIndex].DataBoundItem as Person;

                    if (selectedPerson != null)
                    {
                        using (Forms.AddOrChangePersonForm addPersonForm = new Forms.AddOrChangePersonForm(selectedPerson))
                        {
                            if (addPersonForm.ShowDialog() == DialogResult.OK)
                            {
                                databaseConnection.CreateOrUpdatePerson(addPersonForm.person);
                            }
                        }
                    }
                }

                dataGridViewPersons.DataSource = databaseConnection.GetPeoples();
            } else
            {
                MessageBox.Show("Ни один пользователь не был выбран.");
            }
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersons.SelectedRows.Count > 0 || dataGridViewPersons.SelectedCells.Count > 0)
            {
                var uniqueRowIndices = dataGridViewPersons.SelectedCells
                    .Cast<DataGridViewCell>()
                    .Select(cell => cell.RowIndex)
                    .Distinct();
                foreach (int rowIndex in uniqueRowIndices)
                {
                    Person selectedPerson = dataGridViewPersons.Rows[rowIndex].DataBoundItem as Person;
                    databaseConnection.DeletePerson(selectedPerson);
                }
                dataGridViewPersons.DataSource = databaseConnection.GetPeoples();
            }
            else
            {
                MessageBox.Show("Ни один пользователь не был выбран.");
            }
        }

        private void buttonFillData_Click(object sender, EventArgs e)
        {
            databaseConnection.QuickFill();
            dataGridViewPersons.DataSource = databaseConnection.GetPeoples();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "maleName";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void поискПоФамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "lastname";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void поискПоИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "firstname";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void ктоЖиветНаУлицеПушкинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "pushkina";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void ктоНеЗанимаетсяТяжелойАтлетикойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "nothathlete";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void ктоРодилсяСегодняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "dobnow";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void ктоРодилсяВXГодуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "dob";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void уКогоНомерДомаМеньше50ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "ht50";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void уКогоНомерКвартирыМеньше12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "ft12";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void уКогоНетХоббиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.SearchForm searchForm = new Forms.SearchForm())
            {
                searchForm.s = "hobbynull";
                if (searchForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
