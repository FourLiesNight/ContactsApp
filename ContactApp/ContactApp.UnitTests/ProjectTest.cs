using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using ContactApp;

namespace ContactApp.UnitTests
{
    public class ProjectTest
    {
        //Тест свойства ContactsList
        [Test(Description = "Позитивный тест геттера ContactsList")]
        public void TestContactsListGet_CorrectValue()
        {
            Project project = new Project();

            var expected = new List<Contact>();
            project.PhoneList = expected;
            var actual = project.PhoneList;
            ClassicAssert.AreEqual(expected, actual, "Геттер ContactsList возвращает неправильный список контактов");
        }

        [Test(Description = "Позитивный тест сеттера ContactsList")]
        public void TestContactsListSet_CorrectValue()
        {
            try
            {
                Project project = new Project();
                List<Contact> contactslist = new List<Contact>();

            }
            catch (ArgumentException ex) { }
        }
    }
}