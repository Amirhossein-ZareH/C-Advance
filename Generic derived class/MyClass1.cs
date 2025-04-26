using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_derived_class
{
    internal class MyClass1
    {
        int a;

        public MyClass1(int a)
        {
            this.a = a;
        }
        public void print()
        {
            Console.WriteLine("A is : {0}",a);
        }
    }
}
