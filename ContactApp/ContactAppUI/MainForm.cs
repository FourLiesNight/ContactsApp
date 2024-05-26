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

            //Загружаем из файла контакты и заполняем фамилии в listbox(если контакты есть)
            AllContacts.PhoneList = ProjectManager.LoadFromFile();
            if (AllContacts.PhoneList != null)
                for (int i = 0; i < AllContacts.PhoneList.Count; i++)
                    ContactsListBox.Items.Add(AllContacts.PhoneList[i].Surname);
            else
                AllContacts.PhoneList = new List<Contact>();

        }

        public Project AllContacts = new Project();

        private void ContactsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            //Вывод необходимого контакта на экран
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

            if (addData.Contact != null)
            { 
                //Обрабатываем данные из формы(Добваляем в имеющийся список контактов новые данные, добавляем новую фамилию в список)
                AllContacts.PhoneList.Add(addData.Contact);
                ContactsListBox.Items.Add(addData.Contact.Surname);

                //Сохраняем в файл
                ProjectManager.SaveToFile(AllContacts.PhoneList);
            }
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                //Инициализируем форму и передаем данные для изменения
                EditForm editData = new EditForm();
                editData.Contact = AllContacts.PhoneList[ContactsListBox.SelectedIndex];
                editData.ShowDialog();

                if (editData.Contact != null)
                {
                    //Перезаписываем данные
                    var editedData = editData.Contact;
                    AllContacts.PhoneList[ContactsListBox.SelectedIndex] = editedData;
                    ContactsListBox.Items[ContactsListBox.SelectedIndex] = editedData.Surname;

                    ProjectManager.SaveToFile(AllContacts.PhoneList);
                }
            }
            else
                MessageBox.Show("No contact selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Инициализируем и показываем форму
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                //DialogResult держит в себе какую кнопку в messagebox нажали
                DialogResult = MessageBox.Show("Are you sure you want to delete this contact?", "Delete contact", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //Если в messagebox нажали "да", то удаляем
                if (DialogResult == DialogResult.Yes)
                {
                    //Чистка в списке контактов и удаление фамилии из listbox
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