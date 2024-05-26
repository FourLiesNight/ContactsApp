using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ContactApp.UnitTests
{

    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;
        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
        }

        //Тест свойства Surname
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.Surname = expected;
            var actual = _contact.Surname;
            ClassicAssert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }

        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка", TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов", "Должно возникать исключение, если фамилия длиннее 50 символов", TestName = "Присвоение неправильной фамилии больше 50 символов")]
        public void TestSurnameSet_ArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Surname = wrongSurname; },
            message);
        }

        //Тест свойства Name
        [Test(Description = "Позитивный тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Анатолий";
            _contact.Name = expected;
            var actual = _contact.Name;
            ClassicAssert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }
        [TestCase("", "Должно возникать исключение, если имя - пустая строка", TestName = "Присвоение пустой строки в качестве имени")]
        [TestCase("Ибрагим-Ибрагим-Ибрагим-Ибрагим-Ибрагим-Ибрагим-Ибрагим-Ибрагим", "Должно возникать исключение, если имя длиннее 50 символов", TestName = "Присвоение неправильного имени больше 50 символов")]
        public void TestNameSet_ArgumentException(string wrongName, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Name = wrongName; },
            message);
        }

        //Тест свойства PhoneNumber
        [Test(Description = "Позитивный тест геттера PhoneNumber")]
        public void TestPhoneNumberGet_CorrectValue()
        {
            var expected = 79059923030;
            _contact.number.Number = expected;
            var actual = _contact.number.Number;
            ClassicAssert.AreEqual(expected, actual, "Геттер PhoneNumber возвращает неправильный номер телефона");
        }
        [TestCase(89096756767, "Должно возникать исключение, если номер телефона начинается не с 7", TestName = "Номер телефона начинается не с 7")]
        [TestCase(9096756767, "Должно возникать исключение, если номер состоит меньше,чем из 11 цифр", TestName = "Присваивание номера менее 11 цифр")]
        [TestCase(789096756767, "Должно возникать исключение, если номер состоит более,чем из 11 цифр", TestName = "Присваивание номера более 11 цифр")]
        public void TestPhoneNumberSet_ArgumentException(long wrongNumber, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.number.Number = wrongNumber; },
            message);
        }

        //Тест свойства Birthday
        [Test(Description = "Позитивный тест геттера Birthday")]
        public void TestBirthdayGet_CorrectValue()
        {
            var expected = DateTime.Today;
            _contact.Birthday = expected;
            var actual = _contact.Birthday;
            ClassicAssert.AreEqual(expected, actual, "Геттер Birthday возвращает неправильную дату рождения");
        }
        [TestCase("1899.12.12", "Должно возникать исключение, если год ранее 1900", TestName = "Присвоение даты ранее 1900 года")]
        [TestCase("2024.05.27", "Должно возникать исключение, если дата больше текущего дня", TestName = "Присвоение даты позднее текущего дня")]
        public void TestBirthdaySet_ArgumentException(DateTime wrongDate, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Birthday = wrongDate; },
            message);
        }

        //Тест свойства Mail
        [Test(Description = "Позитивный тест геттера Mail")]
        public void TestMailGet_CorrectValue()
        {
            var expected = "example@mail.ru";
            _contact.Mail = expected;
            var actual = _contact.Mail;
            ClassicAssert.AreEqual(expected, actual, "Геттер Mail возвращает неправильный адрес почты");
        }
        [TestCase("", "Должно возникать исключение, если адрес почты - пустая строка", TestName = "Присвоение пустой строки в качестве адреса почты")]
        [TestCase("grundstucksvehrkehrgenehmigungzustangihkeit@mail.ru", "Должно возникать исключение, если адрес почты более 50 символов", TestName = "Присвоение адресу почты более 50 символов")]
        public void TestMailSet_ArgumentException(string wrongMail, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Mail = wrongMail; },
            message);
        }

        //Тест свойства Id
        [Test(Description = "Позитивный тест геттера Id")]
        public void TestIdGet_CorrectValue()
        {
            var expected = 45678994;
            _contact.IdVk = expected;
            var actual = _contact.IdVk;
            ClassicAssert.AreEqual(expected, actual, "Геттер Id возвращает неправильный id VK");
        }
    }
}
