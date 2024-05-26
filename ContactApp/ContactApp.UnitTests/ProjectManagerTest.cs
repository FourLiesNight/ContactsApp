using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Collections.Generic;

namespace ContactApp.UnitTests
{
    [TestFixture]
    public class ProjectManagerTests
    {
        //Тест сохранения в файл
        [Test(Description = "Позитивный тест сохранения файла")]
        public void SaveToFile_SavesDataToFile()
        {
            List<Contact> contacts = new List<Contact>
            {
                new Contact { Name = "Alice", Surname = "Peterson" },
                new Contact { Name = "Bob", Surname = "Pe" }
            };

            ProjectManager.SaveToFile(contacts);

            //Проверка файла на существование, после предыдущей строки
            ClassicAssert.IsTrue(System.IO.File.Exists("C:\\Users\\chemo\\Documents\\Visual Studio Solutions\\ContactApp\\ContactApp\\ContactApp\\Contacts.txt"));
        }

        //Тест загрузки файла
        [Test(Description = "Позитивный тест загрузки файла")]
        public void LoadFromFile_LoadsDataFromFile()
        {
            List<Contact> loadedContacts = ProjectManager.LoadFromFile();

            //В файле есть содержимое
            ClassicAssert.IsNotNull(loadedContacts);
        }
    }
}