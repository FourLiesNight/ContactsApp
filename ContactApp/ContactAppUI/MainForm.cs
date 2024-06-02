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
                    if (item.Birthday.Day == DateTime.Today.Day && item.Birthday.Month == DateTime.Today.Month)
                    {
                        BirthDayListBox.Visible = true; // Появление списка именинников
                        BirthDayListBox.Items.Add(item.Surname); //Добавление фамилии в список
                    }
                }
            }
            else
                AllContacts.PhoneList = new List<Contact>(); //Если нет контактов - инициализация списка для хранения
        }

        // Вывод необходимого контакта на экран
        private void ContactsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1) 
            {
                // Заполнение информации о контакте из list
                currentSelectedContact = AllContacts.GetContactBySurname(ContactsListBox.SelectedItem.ToString());

                // Заполняем текстбоксы информацией
                SurnameTextBox.Text = currentSelectedContact.Surname;
                NameTextBox.Text = currentSelectedContact.Name;
                BirthdayTimePicker.Value = currentSelectedContact.Birthday;
                PhoneTextBox.Text = currentSelectedContact.number.Number.ToString();
                EmailTextBox.Text = currentSelectedContact.Mail;
                VKTextBox.Text = currentSelectedContact.IdVk;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Инициализация формы и экземпляра класса контакт для добавления нового контакта
            EditForm addData = new EditForm();
            addData.Contact = new Contact();
            addData.ShowDialog();

            if (addData.DialogResult == DialogResult.OK)
            {
                //Обрабатываем данные из формы(Добваляем в имеющийся список контактов новые данные, добавляем новую фамилию в список)
                AllContacts.PhoneList.Add(addData.Contact);
                ContactsListBox.Items.Add(addData.Contact.Surname);

                //Сохраняем в файл и обновляем список
                ProjectManager.SaveToFile(AllContacts.PhoneList);
                UpdateListBox();
            }
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex != -1)
            {
                // Выбранную фамилию запоминаем, с ее помощью в осн. списке ищем всю информацию
                // Передаем эту информацию в Contact в EditForm
                string contactSurnameToChange = ContactsListBox.SelectedItem.ToString();
                EditForm editData = new EditForm();
                editData.Contact = AllContacts.GetContactBySurname(contactSurnameToChange);
                editData.ShowDialog();

                // Если нажали OK
                if (editData.DialogResult == DialogResult.OK)
                {
                    // Передаем Contact из EditData сюда
                    Contact editedContact = editData.Contact;
                    // Ищем настоящий индекс контакта в осн. списке
                    // На случай, если искали контакт в find и единственную фамилию в ListBox изменяли
                    int changeDataIndex = FindRealIndex(contactSurnameToChange);

                    //Удаляем старые данные и вносим новые
                    ContactsListBox.Items.RemoveAt(changeDataIndex);
                    ContactsListBox.Items.Add(editedContact.Surname);

                    //Сохранение, обновление списка
                    ProjectManager.SaveToFile(AllContacts.PhoneList);
                    UpdateListBox();
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
                    int realIndex = FindRealIndex(ContactsListBox.SelectedItem.ToString());

                    //Чистка в списке контактов и удаление фамилии из listbox
                    AllContacts.PhoneList.RemoveAt(realIndex);
                    ContactsListBox.Items.RemoveAt(realIndex);
                    ProjectManager.SaveToFile(AllContacts.PhoneList);

                    MessageBox.Show("Contact has been deleted!", "Delete contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateListBox();
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
                // Очищаем весь список и ищем по введеной подстроке необходимую фамилию
                ContactsListBox.Items.Clear();

                foreach (var item in AllContacts.PhoneList)
                    if (item.Surname.ToLower().Contains(request.ToLower()))
                        ContactsListBox.Items.Add(item.Surname);
            }
            else
            {
                // Когда стерли findbox
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
                currentSelectedContact = AllContacts.GetContactBySurname(BirthDayListBox.SelectedValue.ToString());

                // Заполняем текстбоксы информацией
                SurnameTextBox.Text = currentSelectedContact.Surname;
                NameTextBox.Text = currentSelectedContact.Name;
                BirthdayTimePicker.Value = currentSelectedContact.Birthday;
                PhoneTextBox.Text = currentSelectedContact.number.Number.ToString();
                EmailTextBox.Text = currentSelectedContact.Mail;
                VKTextBox.Text = currentSelectedContact.IdVk;
            }
        }

        private void ContactsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Если был нажат "Delete" и выбрана фамилия в listbox
            if (e.KeyCode == Keys.Delete && ContactsListBox.SelectedIndex != -1)
            {
                DialogResult = MessageBox.Show("Are you sure you want to delete this contact?", "Delete contact",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    int realIndex = FindRealIndex(ContactsListBox.SelectedItem.ToString());

                    //Чистка в списке контактов и удаление фамилии из listbox
                    AllContacts.PhoneList.RemoveAt(realIndex);
                    ContactsListBox.Items.RemoveAt(realIndex);
                    ProjectManager.SaveToFile(AllContacts.PhoneList);

                    MessageBox.Show("Contact has been deleted!", "Delete contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Функция, обновляющая ListBox
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (var item in AllContacts.PhoneList)
                ContactsListBox.Items.Add(item.Surname);
        }

        /// <summary>
        /// Производит поиск настоящего индекса контакта в Listbox по фамилии
        /// </summary>
        private int FindRealIndex(string _key)
        {
            for (int i = 0; i <= ContactsListBox.Items.Count; i++)
                if (ContactsListBox.Items[i].ToString() == _key)
                    return i;

            return -1;
        }

        private Contact currentSelectedContact = new Contact();
        private Project AllContacts = new Project();
    }
}