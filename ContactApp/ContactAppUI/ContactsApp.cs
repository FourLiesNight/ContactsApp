using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ContactApp;

namespace ContactAppUI
{
    public partial class ContactsApp : Form
    {
        public ContactsApp()
        {
            InitializeComponent();

            var contact = new Contact(); //Создание экземпляра класса "Contact"
            var contact2 = new Contact(); //Создание второго экземпляра класса "Contact");

            List<Contact> phoneList = new List<Contact>(); //Создание экземпляра класса "Project"

            contact.SetSurname("Parker");
            contact.SetName("Peter");
            contact.number.SetNumber(79528120052);
            contact.SetBirthday(new DateTime(1999, 8, 27));
            contact.SetMail("spiderman@mail.com");
            contact.SetVk(4545344);

            contact2.SetSurname("Parker");
            contact2.SetName("Ben");
            contact2.number.SetNumber(79528120052);
            contact2.SetBirthday(new DateTime(1966, 5, 6));
            contact2.SetMail("notspiderman@yandex.ru");
            contact2.SetVk(6765344);


            phoneList.Add(contact); //Добавление экземляра "Contact" в список
            phoneList.Add(contact2); //Добавление экземляра "Contact2" в список


            for (int i = 0; i < phoneList.Count; i++)//Вывод
            {
                Console.WriteLine(phoneList[i].GetName());
                Console.WriteLine(phoneList[i].GetSurname());
                Console.WriteLine(phoneList[i].number.GetNumber());
                Console.WriteLine(phoneList[i].GetBirthday());
                Console.WriteLine(phoneList[i].GetMail());
                Console.WriteLine(phoneList[i].GetVk());
                Console.WriteLine(" ");
            }

            ProjectManager.SaveToFile(phoneList); //Загрузка списка контактов в файл
            //Console.WriteLine(ProjectManager.LoadFromFile()); //Выгрузка из файла
        }
    }
}