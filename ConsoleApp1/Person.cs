using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int i;
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="name">Имя</param>
        public Person(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Выводим имя в консоль
        /// </summary>
        public void Show()
        {
            Console.WriteLine(name);
        }

        /// <summary>
        /// Свойство
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Задаём число i
        /// </summary>
        public int I { get => i; set => i = value; }


        public bool IsPositive
        {
            get
            {
                return (i > 0);
            }
        }
    }
}
