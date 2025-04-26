using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generic_derived_class
{
    class MyClass4 <T1,T2>
    {
        T1 a;
        T2 b;

        public MyClass4(T1 a, T2 b)
        {
            this.a = a;
            this.b = b;
        }
        public void Print()
        {
            Console.WriteLine("A is : {0}\tB is : {1}",a,b);
        }
        public T1 Getter()
        {
            return a;
        }
    }
}
