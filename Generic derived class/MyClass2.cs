using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_derived_class
{
    internal class MyClass2
    {
        string a;

        public MyClass2(string a)
        {
            this.a = a;
        }
        public void print()
        {
            Console.WriteLine("A is : {0}", a);
        }
    }
}
