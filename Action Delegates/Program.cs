using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegates
{
    internal class Program
    {
        public static Action<int, int> del1 = Fun1;
        public static Action<int> printInt = Print;
        public static Action<string> printString = Print;
        static void Main(string[] args)
        {
            del1.Invoke(22, 22);
            printInt.Invoke(22);
            printString.Invoke("amir");

            Action<string> printStr = delegate (string str)
            {
                Console.WriteLine(str);
            };
            printStr.Invoke("Amir");
        }
        public static void Fun1(int a, int b)
        {
            Console.WriteLine("A is : {0}\tB is : {1}", a, b);
        }
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
        public static void Print(int num)
        {
            Console.WriteLine(num);
        }

    }
}
