using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ContactApp
{
    /// <summary>
    /// Класс, хранящий номер телефона абонента, а также информацию о номере.
    /// </summary>
    public class PhoneNumber
    {
        private long _number;

        /// <summary>
        /// Задает и возвращает номер телефона.
        /// </summary>
        public long Number
        {
            get { return _number; }

            set
            {
                if (value != null && value.ToString().Length == 11 && (int)(value / Math.Pow(10, 10)) == 7)
                    _number = value;
                else
                    throw new ArgumentException("Неверно набран номер");
            }
        }

        /// <summary>
        /// Метод, для записи номера телефона(метод set).
        /// </summary>
        public void SetNumber(long number)
        {
            if (number != null && number.ToString().Length == 11 && (int)(number / Math.Pow(10, 10)) == 7)
                Number = number;
            else
                throw new ArgumentException("Неверно набран номер");
        }

        /// <summary>
        /// Метод для получения номера телефона(метод get).
        /// </summary>
        public long GetNumber()
        {
            return Number;
        }
    }
}