using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using ContactApp;

namespace ContactAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AllContacts.PhoneList = ProjectManager.LoadFromFile();
            ContactsListBox.Items.Clear();

            if (AllContacts.PhoneList != null)
                for(int i = 0; i < AllContacts.PhoneList.Count; i++)
                    ContactsListBox.Items.Add(AllContacts.PhoneList[i].Surname);
        }

        public Project AllContacts = new Project();

        private void ContactsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1) 
            {
                var selectedSurname = AllContacts.PhoneList[ContactsListBox.SelectedIndex];

                SurnameTextBox.Text = selectedSurname.Surname;
                NameTextBox.Text = selectedSurname.Name;
                BirthdayTimePicker.Value = selectedSurname.Birthday;
                PhoneTextBox.Text = selectedSurname.number.Number.ToString();
                EmailTextBox.Text = selectedSurname.Mail;
                VKTextBox.Text = selectedSurname.IdVk.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Инициализация формы и экземпляр класса контакт для добавления нового контакта
            EditForm addData = new EditForm();
            addData.Contact = new Contact();
            addData.ShowDialog();

            //Обрабатываем данные из формы(Добваляем в имеющийся список контактов новые данные, добавляем новую фамилию в список)
            AllContacts.PhoneList.Add(addData.Contact);
            ContactsListBox.Items.Add(addData.Contact.Surname);

            //Сохраняем в файл
            ProjectManager.SaveToFile(AllContacts.PhoneList);
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                //Инициализируем форму и передаем данные для изменения
                EditForm editData = new EditForm();
                editData.Contact = AllContacts.PhoneList[ContactsListBox.SelectedIndex];
                editData.ShowDialog();

                //Перезаписываем данные
                var editedData = editData.Contact;
                AllContacts.PhoneList[ContactsListBox.SelectedIndex] = editedData;
                ContactsListBox.Items[ContactsListBox.SelectedIndex] = editedData.Surname;

                ProjectManager.SaveToFile(AllContacts.PhoneList);
            }
            else
                MessageBox.Show("No contact selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                DialogResult = MessageBox.Show("Are you sure you want to delete this contact?", "Delete contact", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    AllContacts.PhoneList.RemoveAt(ContactsListBox.SelectedIndex);
                    ContactsListBox.Items.RemoveAt(ContactsListBox.SelectedIndex);
                    ProjectManager.SaveToFile(AllContacts.PhoneList);

                    MessageBox.Show("Contact has been deleted!", "Delete contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("No contact selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}