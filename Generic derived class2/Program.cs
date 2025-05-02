using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_derived_class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1,"amir","zare");
            Console.WriteLine(person1.ToString());

            MyClass<string,int> class1 = new MyClass<string, int>("amir",21);
            //class1.Print();
            Console.WriteLine(class1.GetType());

            MyClass<Person,int> class2 = new MyClass<Person, int>(new Person(2,"amir","akbari"),22);
            //class2.Print();
            Console.WriteLine(class2.GetType());

            

        }
    }
}
