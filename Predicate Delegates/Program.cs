using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> age = AgeValidate;
            Console.WriteLine(age.Invoke(22));
        }
        public static bool AgeValidate(int age)
        {
            return age > 0 && age < 100;//? true : false;
        }
    }
}
