using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Delegate
{
    internal class Program
    {
        public delegate void MyDelegate1<T1, T2>(T1 a , T2 b);

        public delegate T3 MyDelegate2<T1, T2, T3>(T1 a, T2 b);
        static void Main(string[] args)
        {
            MyDelegate2<string, bool, int> del1 = Fun4;
            Console.WriteLine(del1.Invoke("amir",false));



            MyDelegate1<int, string> a1 = Fun1;
            a1.Invoke(22, "amir");
        }

        public static void Fun1(int x , string y)
        {
            Console.WriteLine("X is : {0}\tY is : {1}",x,y);
        }
        public static void Fun2(float x , bool  y)
        {
            Console.WriteLine("X is : {0}\tY is : {1}",x,y);
        }
        public static void Fun3(float x , double y)
        {
            Console.WriteLine("X is : {0}\tY is : {1}",x,y);
        }
        public static int Fun4(string name, bool flag)
        {
            Console.WriteLine("Hello {0}",name);
            return flag ?  0 : 1 ;
        }
    }
}
