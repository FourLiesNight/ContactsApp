using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ContactApp
{
    /// <summary>
    /// Класс, который содержит список всех контактов, созданных в приложении.
    /// </summary>
    public class Project
    {
        private List<Contact> _list;
        public List<Contact> PhoneList
        {
            get 
            {
                if (_list != null)
                    _list.Sort();

                return _list; 
            }

            set
            { _list = value; }
        }
        
        /// <summary>
        /// Производит поиск по фамилии в PhoneList
        /// </summary>
        public Contact GetContactBySurname(string _surname)
        {
            foreach (Contact item in PhoneList)
                if (item.Surname ==  _surname)
                    return item;
            return null;
        }
    }
}
