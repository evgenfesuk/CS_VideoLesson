using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClassB : Person
    {
        public ClassB(string name) : base(name)
        {
        }

        public override void a()
        {
            Console.WriteLine('b');
        }
    }
}
