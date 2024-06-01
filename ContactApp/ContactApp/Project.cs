using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

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
                _list.Sort();
                return _list; 
            }

            set
            { _list = value; }
        }
    }
}
