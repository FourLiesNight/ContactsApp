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
            {
                foreach (var item in AllContacts.PhoneList)
                {
                    ContactsListBox.Items.Add(item.Surname); // Добавление фамилии контакта в список

                    // Если число и месяц дня рождения совпадает с "сегодняшним"
                    if (item.Birthday.Day ==  DateTime.Today.Day && item.Birthday.Month == DateTime.Today.Month)
                    {
                        BirthDayListBox.Visible = true; // Появление списка именинников
                        BirthDayListBox.Items.Add(item.Surname); //Добавление фамилии в список
                    }
                }
            }
            else
                AllContacts.PhoneList = new List<Contact>(); //Если нет контактов - инициализация списка для хранения
        }

        private void ContactsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Вывод необходимого контакта на экран
            if (ContactsListBox.SelectedIndex != -1) 
            {
                // Выбираем выделенную фамилию
                var selectedSurname = ContactsListBox.SelectedItem.ToString();

                // Среди всего списка контактов ищем контакта с выделенной фамилией
                var item = SearchContactBySurname(selectedSurname);

                // Заполняем текстбоксы информацией
                SurnameTextBox.Text = item.Surname;
                NameTextBox.Text = item.Name;
                BirthdayTimePicker.Value = item.Birthday;
                PhoneTextBox.Text = item.number.Number.ToString();
                EmailTextBox.Text = item.Mail;
                VKTextBox.Text = item.IdVk.ToString();
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
                editData.Contact = SearchContactBySurname(ContactsListBox.SelectedItem.ToString());
                editData.ShowDialog();

                // При нажатии Cancel в EditForm экземпляр Contact принимает null
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

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            string request = FindTextBox.Text;

            if (!string.IsNullOrEmpty(request))
            {
                ContactsListBox.Items.Clear();

                foreach (var item in AllContacts.PhoneList)
                    if (item.Surname.ToLower().Contains(request.ToLower()))
                        ContactsListBox.Items.Add(item.Surname);
            }
            else
            {
                ContactsListBox.Items.Clear();

                foreach (var item in AllContacts.PhoneList)
                    ContactsListBox.Items.Add(item.Surname);
            }
        }

        private void BirthDayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BirthDayListBox.SelectedIndex != -1 && BirthDayListBox.SelectedIndex != 0)
            {
                // Среди всего списка контактов ищем контакта с выделенной фамилией
                var item = SearchContactBySurname(BirthDayListBox.SelectedItem.ToString());

                // Заполняем текстбоксы информацией
                SurnameTextBox.Text = item.Surname;
                NameTextBox.Text = item.Name;
                BirthdayTimePicker.Value = item.Birthday;
                PhoneTextBox.Text = item.number.Number.ToString();
                EmailTextBox.Text = item.Mail;
                VKTextBox.Text = item.IdVk.ToString();
            }
        }

        private void ContactsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && ContactsListBox.SelectedIndex != -1)
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
        }

        // Поиск контакта по фамилии
        private Contact SearchContactBySurname(string _surname)
        {
            try
            {
                foreach (var item in AllContacts.PhoneList)
                    if (_surname == item.Surname)
                        return item;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public Project AllContacts = new Project();
    }
}