using ContactApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.UnitTests
{
    public class PhoneNumberTest
    {
        //Тест свойства PhoneNumber
        [Test(Description = "Позитивный тест геттера Number")]
        public void TestNumberGet_CorrectValue()
        {
            var phonenumber = new PhoneNumber();
            var expected = 79059923030;
            phonenumber.Number = expected;
            var actual = phonenumber.Number;
            ClassicAssert.AreEqual(expected, actual, "Геттер Number возвращает неправильный номер телефона");
        }

        [TestCase(89096756767, "Должно возникать исключение, если номер телефона начинается не с 7", TestName = "Номер телефона начинается не с 7")]
        [TestCase(9096756767, "Должно возникать исключение, если номер состоит меньше,чем из 11 цифр", TestName = "Присваивание номера менее 11 цифр")]
        [TestCase(789096756767, "Должно возникать исключение, если номер состоит более,чем из 11 цифр", TestName = "Присваивание номера более 11 цифр")]
        public void TestPhoneNumberSet_ArgumentException(long wrongNumber, string message)
        {
            var phonenumber = new PhoneNumber();
            Assert.Throws<ArgumentException>(
            () => { phonenumber.Number = wrongNumber; },
            message);
        }
    }
}
