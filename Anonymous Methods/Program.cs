using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Methods
{
    internal class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string a,string b);
        static void Main(string[] args)
        {
            MyDelegate star = delegate 
            {
                for (int i = 0; i < 10; i++)
                {
                   // Console.Write("* ");
                }
            };
            star();

            MyDelegate2 Name = delegate(string name,string family) 
            {
                Console.WriteLine("Name is : {0}\tFamily is : {1}",name,family);
            };
            string nameP = Console.ReadLine();
            string familyP = Console.ReadLine();
            //Name(nameP,familyP);
            PrintName(Name,nameP,familyP);
        }
        //example
        public static void PrintName(MyDelegate2 a,string name,string family)
        {
            a(name,family);
        }
    }
}
