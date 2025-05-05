using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Query_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,16 };


            var list = from t in age
                       where t.ToString().Contains("6")
                       select t;

            
            //var list = from t in age
                       //where t < 20 && t > 10
                       //orderby t descending
                      // select t;

            
            //var list = from t in age
            //           where t< 20 && t > 10
            //           orderby t
            //           select t;


            
           // int[] list = (from t in age
           //           where t > 0
           //           select t).ToArray();




            // var list = from t in age
            //            where t < 20 && t > 10
            //            select t;




           // var list = from t in age
           //            where t <30 
           //            select t;



            //var list = from t in age
            //           select t;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
