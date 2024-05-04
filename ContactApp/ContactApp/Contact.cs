using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ContactApp
{
    /// <summary>
    /// Класс, в котором содержится информация об абоненте.
    /// </summary>
    public class Contact

    {
        public string Surname;
        public string Name;
        public PhoneNumber number = new PhoneNumber();
        public DateTime Birthday;
        public string Mail;
        public int IdVk;

        /// <summary>
        /// Метод, записывающий фамилию абонента(метод set).
        /// </summary>
        public void SetSurname(string surname)
        {
            if (!string.IsNullOrEmpty(surname) && surname.Length <= 50)
                Surname = char.ToUpper(surname[0]) + surname.Substring(1);
            else
                throw new ArgumentException("Фамилия не должна быть пустой и должна быть менее 50 символов");
        }

        /// <summary>
        /// Метод, записывающий имя абонента(метод set).
        /// </summary>
        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name) && name.Length <= 50)
                Name = char.ToUpper(name[0]) + name.Substring(1);
            else
                throw new ArgumentException("Имя не должно быть пустым и должно быть менее 50 символов");
        }

        /// <summary>
        /// Метод, запсывающий дату рождения абонента(метод set).
        /// </summary>
        public void SetBirthday(DateTime birthday)
        {
            if (birthday.Year > 1900 && birthday.Date <= DateTime.Today)
                Birthday = birthday;
            else
                throw new ArgumentException("Ошибка ввода даты рождения");
        }

        /// <summary>
        /// Метод, записывающий электронный адрес абонента(метод set).
        /// </summary>
        public void SetMail(string mail)
        {
            if (!string.IsNullOrEmpty(mail) && mail.Length <= 50)
                Mail = mail;
            else
                throw new ArgumentException("Почтовый адрес не должен быть пустым и должно быть менее 50 символов");
        }

        /// <summary>
        /// Метод, записывающий id абонента во ВКонтакте(метод set).
        /// </summary>
        public void SetVk(int id)
        {
            if (id != null && id.ToString().Length <= 15)
                IdVk = id;
            else 
                throw new ArgumentException("id ВКонтакте не должно быть пустым и должно быть менее 15 символов");
        }

        /// <summary>
        /// Метод, возвращающий фамилию абонента(метод get).
        /// </summary>
        public string GetSurname()
        {
            return Surname;
        }

        /// <summary>
        /// Метод, возвращающий имя абонента(метод get).
        /// </summary>
        public string GetName()
        {
            return Name;
        }

        /// <summary>
        /// Метод, возвращающий дату рождения абонента(метод get).
        /// </summary>
        public DateTime GetBirthday()
        {
            return Birthday;
        }

        /// <summary>
        /// Метод, возвращающий почтовый адрес абонента(метод get).
        /// </summary>
        public string GetMail()
        {
            return Mail;
        }

        /// <summary>
        /// Метод, возвращающий id абонента во ВКонтакте(метод get).
        /// </summary>
        public int GetVk()
        {
            return IdVk;
        }
    }
}