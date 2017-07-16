using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("name");
            p.Show();
            p.Name = "new";
            p.Show();
            Console.WriteLine(p.Name);
            p.I = 1;
            Console.WriteLine(p.IsPositive);
            Console.ReadKey();
        }
    }
}
