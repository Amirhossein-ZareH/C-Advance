using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_derived_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass3<string> class1 = new MyClass3<string>("amir");
            class1.Print();

            MyClass3<int> class2 = new MyClass3<int>(2);
            class2.Print();

            MyClass3<bool> class3 = new MyClass3<bool>(false);

            MyClass4<int, string> class4 = new MyClass4<int, string>(22, "amir");
            class4.Print();
            Console.WriteLine(class4.Getter());

            MyClass4< string, int> class5 = new MyClass4< string, int>("amir", 22 );
            class5.Print();
            Console.WriteLine(class5.Getter());

            MyClass4<string, string> class6 = new MyClass4<string, string>("amir", "hanie");
            class6.Print();
            Console.WriteLine(class6.Getter());
        }
    }
}
