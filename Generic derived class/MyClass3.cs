using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_derived_class
{
    internal class MyClass3<T>
    {
        T a;

        public MyClass3(T a)
        {
            this.a = a;
        }
        public void Print()
        {
            Console.WriteLine("Your A is : {0}",a);
        }
    }
}
