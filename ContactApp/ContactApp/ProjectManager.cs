using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp;
using Newtonsoft.Json;

namespace ContactApp
{
    /// <summary>
    /// Класс, который копирует списки контактов из приложения и добавляет их в отдельный файл на компьютере.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Метод для сохранения данных в файл.
        /// </summary>
        public static void SaveToFile(object data)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (var sw = new StreamWriter("C:\\Users\\chemo\\Documents\\Visual Studio Solutions\\ContactApp\\ContactApp\\ContactApp\\Contacts.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, data); //Вызываем сериализацию и передаем объект, который хотим сериализовать
        }

        /// <summary>
        /// Метод для загрузки файлов из файла.
        /// </summary>
        public static object LoadFromFile()
        {
            Contact temp = null;
            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader("~\\note.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                temp = (Contact)serializer.Deserialize<Contact>(reader);
                Console.WriteLine($"Surname: {temp.Surname}");
                Console.WriteLine($"Name: {temp.Name}");
                Console.WriteLine($"PhoneNumber: {temp.number.Number}");
                Console.WriteLine($"Surname: {temp.Birthday}");
                Console.WriteLine($"E-mail: {temp.Mail}");
                Console.WriteLine($"ID ВКонтакте: {temp.IdVk}");
            }

            return 0;
        }
    }
}