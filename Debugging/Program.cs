using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        public delegate void PrintClass(int number);
        static void Main(string[] args)
        {
            //Thrace
            //break point
            PrintClass amir = PrintA;
            Print(amir,26);
        }
        public static void Print(PrintClass a,int b)
        {
            a(b);
        }
        public static void PrintA(int number)
        {
            Console.WriteLine("Ali"+number);
        }
    }
}
