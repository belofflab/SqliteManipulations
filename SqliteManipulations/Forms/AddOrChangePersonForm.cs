using SqliteManipulations.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SqliteManipulations.Forms
{
    public partial class AddOrChangePersonForm : Form
    {
        public Person person { get; private set; }
        private readonly bool isUpdate;

        public AddOrChangePersonForm(Person includedPerson = null)
        {
            InitializeComponent();
            person = includedPerson;
            isUpdate = (person != null);

            if (isUpdate)
            {
                PrefillData();
            }
        }

        private void PrefillData()
        {
            buttonAddPerson.Text = "Изменить";
            textBoxFirstname.Text = person.FirstName;
            textBoxLastname.Text = person.LastName;
            dateTimePickerDob.Value = person.DateOfBirth;
            textBoxStreet.Text = person.Street;
            textBoxFlat.Text = person.Flat.ToString();
            textBoxHouse.Text = person.House.ToString();
            textBoxClass.Text = person.Class;
            comboBoxGroup.Text = person.UGroup.ToString();
            comboBoxGroup.SelectedItem = person.UGroup;
            textBoxEye.Text = person.EyeColor;
            richTextBoxHobby.Text = person.Hobby;
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstname.Text;
            string lastName = textBoxLastname.Text;
            DateTime dateOfBirth = dateTimePickerDob.Value;
            string street = textBoxStreet.Text;
            string flat = textBoxFlat.Text;
            string house = textBoxHouse.Text;
            string personClass = textBoxClass.Text;
            object group = comboBoxGroup.SelectedItem;
            string eyeColor = textBoxEye.Text;
            string hobby = richTextBoxHobby.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(flat) ||
                string.IsNullOrWhiteSpace(house) || string.IsNullOrWhiteSpace(personClass) ||
                string.IsNullOrWhiteSpace(hobby))
            {
                MessageBox.Show("Вы не до конца заполнили информацию!");
                return;
            }

            if (dateOfBirth > DateTime.Now)
            {
                MessageBox.Show("Ещё не родился?...");
                return;
            }

            if (group == null)
            {
                MessageBox.Show("Не выбрана группа здоровья!");
                return;
            }

            int parsedFlat, parsedHouse;
            if (!int.TryParse(flat, out parsedFlat) || !int.TryParse(house, out parsedHouse))
            {
                MessageBox.Show("Введите корректные значения для номера квартиры и дома.");
                return;
            }

            Person newPerson = new Person
            {
                Id = (isUpdate) ? person.Id : 0,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Street = street,
                Flat = parsedFlat,
                House = parsedHouse,
                Class = personClass,
                UGroup = group.ToString(),
                EyeColor = eyeColor,
                Hobby = hobby,
            };

            person = newPerson;
            DialogResult = DialogResult.OK;
        }

        private void textBoxHouse_KeyUp(object sender, KeyEventArgs e)
        {
            string inputText = textBoxHouse.Text;
            if (!string.IsNullOrEmpty(inputText) && !IsNumeric(inputText))
            {
                textBoxHouse.Text = RemoveNonNumeric(inputText);
            }
        }

        private void textBoxFlat_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBoxFlat.Text;
            if (!string.IsNullOrEmpty(inputText) && !IsNumeric(inputText))
            {
                textBoxFlat.Text = RemoveNonNumeric(inputText);
            }
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private string RemoveNonNumeric(string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }

        private void dateTimePickerDob_ValueChanged(object sender, EventArgs e)
        {
            DateTime dob = dateTimePickerDob.Value;
            TimeSpan age = DateTime.Now - dob;

            int fullYears = (int)Math.Floor(age.TotalDays / 365.25);
            if (dateTimePickerDob.Value > DateTime.Now)
            {
                MessageBox.Show("Ещё не родился?...");
                return;
            }
            if (fullYears > 0)
            {
                labelAge.Text = $"{fullYears} {GetYearString(fullYears)}";
            } else
            {
                int fullDays = (int)age.TotalDays;
                labelAge.Text = $"{fullDays} {GetDayString(fullDays)}";
            }
        }
        private static string GetYearString(int years)
        {
            if (years >= 11 && years <= 14)
            {
                return "лет";
            }

            int lastDigit = years % 10;

            switch (lastDigit)
            {
                case 1:
                    return "год";
                case 2:
                case 3:
                case 4:
                    return "года";
                default:
                    return "лет";
            }
        }
        private static string GetDayString(int days)
        {
            if (days >= 11 && days <= 14)
            {
                return "дней";
            }

            int lastDigit = days % 10;

            switch (lastDigit)
            {
                case 1:
                    return "день";
                case 2:
                case 3:
                case 4:
                    return "дня";
                default:
                    return "дней";
            }
        }
    }
}
