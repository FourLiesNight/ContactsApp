using ContactApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            contactData.Surname = SurnameTextBox.Text;
            contactData.Name = NameTextBox.Text;
            contactData.number.SetNumber(Convert.ToInt64(PhoneTextBox.Text));
            contactData.Birthday = BirthdayTimePicker.Value;
            contactData.Mail = EmailTextBox.Text;
            contactData.IdVk = Convert.ToInt32(VKTextBox.Text);

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
