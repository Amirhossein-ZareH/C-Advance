using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_derived_class2
{
    internal class MyClass<T1,T2>where T1 : class where T2 : struct
    {
        T1 a;
        T2 b;
        public MyClass(T1 a, T2 b)
        {
            this.a = a;
            this.b = b;

        }

        public void Print()
        {
            Console.WriteLine("A is : {0}",a);
        }
    }
}
