using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering___Sorting___Grouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList()
            {
                23,45.654,"amir","Reza","Hani",2234,true,"arshia",false
            };

            var list1 = arrayList.OfType<int>();

            var list2 = arrayList.OfType<string>();

            var list3 = arrayList.OfType<double>();

            var list4 = arrayList.OfType<bool>(); 
            
        }
    }
}
