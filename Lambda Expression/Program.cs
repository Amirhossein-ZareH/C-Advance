using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string> func1 = delegate (int a , int b)
            {
                return (a + b).ToString();
            };

            Func<int, int, string> func2 = (int a,int b) => (a+b).ToString();

            Func<int, int, string> func3 = (a, b) => (a + b).ToString();

            Func<int, int> func4 = number => number * 5;
            
            Console.WriteLine(func1(82, 22));
            Console.WriteLine(func2(82, 22));
            Console.WriteLine(func3(82, 22));
            Console.WriteLine(func4(1382));
            /////////////////////////////////////////////////////////////////
            Action<int> act1 = number => Console.WriteLine(number / 2);

            Action act2 = () => Console.WriteLine("Warning");

            Action<int> act3= number =>
            {
                Console.WriteLine(number / 2);
                Console.WriteLine(number - 2);
                Console.WriteLine(number + 2);
            };

            act1(23);
            act2();
            act3(10);
            
        }
    }
}
