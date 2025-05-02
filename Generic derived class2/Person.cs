using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_derived_class2
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public Person(int Id,string Name,string Family)
        {
            this.Id = Id;
            this.Name = Name;
            this.Family = Family;
        }
        
        public override string ToString()
        {
            //return "Id is : " + Id + " Name is : " + Name + " Family is : " + Family;
            return string.Format("Id is : {0}\tName is : {1}\t\tFamily is : {2}",Id,Name,Family);
        }
    }
}
