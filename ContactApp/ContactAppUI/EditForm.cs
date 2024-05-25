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

                if (contactData != null)
                {
                    SurnameTextBox.Text = contactData.Surname;
                    NameTextBox.Text = contactData.Name;
                    PhoneTextBox.Text = contactData.number.Number.ToString();
                    //BirthdayTimePicker.Value = contactData.Birthday;
                    EmailTextBox.Text = contactData.Mail;
                    VKTextBox.Text = contactData.IdVk.ToString();
                }
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
                contactData.IdVk = Convert.ToInt32(VKTextBox.Text);

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
            if(!Regex.IsMatch(SurnameTextBox.Text, @"[a-zA-Z]+$") || SurnameTextBox.Text.Length > 50)
                SurnameTextBox.BackColor = Color.Red;
            else
                SurnameTextBox.BackColor = Color.White;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(NameTextBox.Text, @"[a-zA-Z]+$") || NameTextBox.Text.Length > 50)
                NameTextBox.BackColor = Color.Red;
            else
                NameTextBox.BackColor = Color.White;
        }

        private void BirthdayTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if(BirthdayTimePicker.Value >= new DateTime(1900, 1, 1) && BirthdayTimePicker.Value <= DateTime.Now)
                birthdayErr.Clear();
            else
                birthdayErr.SetError(BirthdayTimePicker, "Input error!");
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(PhoneTextBox.Text, @"^7\d{10}$"))
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
            if (!Regex.IsMatch(VKTextBox.Text, @"[0-9]+$") || VKTextBox.Text.Length > 15)
                VKTextBox.BackColor = Color.Red;
            else
                VKTextBox.BackColor = Color.White;
        }

        //Метод, который смотрит на цвет textbox
        //Если все белые - ошибок нет
        public bool checkWhiteBoxes()
        {
            if (SurnameTextBox.BackColor == Color.Red)
                return false;

            if (NameTextBox.BackColor == Color.Red)
                return false;

            if (PhoneTextBox.BackColor == Color.Red)
                return false;

            if (EmailTextBox.BackColor == Color.Red)
                return false;

            if (VKTextBox.BackColor == Color.Red)
                return false;

            if (BirthdayTimePicker.Value <= new DateTime(1900, 1, 1) && BirthdayTimePicker.Value >= DateTime.Now)
                return false;

            return true;
        }
    }
}
