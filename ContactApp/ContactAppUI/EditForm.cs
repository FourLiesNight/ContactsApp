using ContactApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactAppUI
{
    public partial class EditForm : Form
    {
        private Contact contactData;
        public Contact Contact
        {
            get { return contactData; }
            set
            {
                contactData = value;
            }
        }

        public EditForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //При нажатии ОК данные должны изменяться(по заданию)
            //Здесь происходит запись/перезапись данных, которые вписали, если нет ошибок
            if (checkWhiteBoxes())
            {
                contactData.Surname = SurnameTextBox.Text;
                contactData.Name = NameTextBox.Text;
                contactData.number.SetNumber(Convert.ToInt64(PhoneTextBox.Text));
                contactData.Birthday = BirthdayTimePicker.Value;
                contactData.Mail = EmailTextBox.Text;
                contactData.IdVk = VKTextBox.Text;

                // Говорим, что нажали ОК
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Some field has wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Contact = null;
            //Просто выход
            this.Close();
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(SurnameTextBox.Text, @"[a-zA-Z]+$") || SurnameTextBox.Text.Length > 50) //Состоит из больших и маленьких букв
                SurnameTextBox.BackColor = Color.Red;
            else
                SurnameTextBox.BackColor = Color.White;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(NameTextBox.Text, @"[a-zA-Z]+$") || NameTextBox.Text.Length > 50) //Состоит из больших и маленьких букв
                NameTextBox.BackColor = Color.Red;
            else
                NameTextBox.BackColor = Color.White;
        }

        private void BirthdayTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(BirthdayTimePicker.Value >= new DateTime(1900, 1, 1) && BirthdayTimePicker.Value <= DateTime.Now)
                birthdayErr.Clear();
            else
                birthdayErr.SetError(BirthdayTimePicker, "Input error!"); // TimePicker красить нельзя - появится ошибка при неправильном вводе
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(PhoneTextBox.Text, @"^7\d{10}$")) // Начинается с 7 и дальше 10 цифр
                PhoneTextBox.BackColor = Color.White;
            else
                PhoneTextBox.BackColor = Color.Red;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox.Text.Length > 50)
                EmailTextBox.BackColor = Color.Red;
            else
                EmailTextBox.BackColor = Color.White;
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(VKTextBox.Text, @"[0-9]+$") || VKTextBox.Text.Length > 15) // Есть цифры
                VKTextBox.BackColor = Color.Red;
            else
                VKTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Осуществляет проверку TextBox на красный цвет и на пустоту
        /// </summary>
        public bool checkWhiteBoxes()
        {
            if (SurnameTextBox.BackColor == Color.Red || string.IsNullOrEmpty(SurnameTextBox.Text))
                return false;

            if (NameTextBox.BackColor == Color.Red || string.IsNullOrEmpty(NameTextBox.Text))
                return false;

            if (PhoneTextBox.BackColor == Color.Red || string.IsNullOrEmpty(PhoneTextBox.Text))
                return false;

            if (EmailTextBox.BackColor == Color.Red || string.IsNullOrEmpty(EmailTextBox.Text))
                return false;

            if (VKTextBox.BackColor == Color.Red || string.IsNullOrEmpty(VKTextBox.Text))
                return false;

            if (BirthdayTimePicker.Value <= new DateTime(1900, 1, 1) && BirthdayTimePicker.Value >= DateTime.Now)
                return false;

            return true;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // Заполнение контакта, если он не пуст
            if (contactData != null)
            {
                SurnameTextBox.Text = contactData.Surname;
                NameTextBox.Text = contactData.Name;
                PhoneTextBox.Text = contactData.number.Number.ToString();
                BirthdayTimePicker.Value = contactData.Birthday;
                EmailTextBox.Text = contactData.Mail;
                VKTextBox.Text = contactData.IdVk;
            }
        }
    }
}
