using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Collections_With_Method_Syntax
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public Person(int PersonId, string Name, string Family)
        {
            this.PersonId = PersonId;
            this.Name = Name;
            this.Family = Family;
        }
        public override string ToString()
        {
            return string.Format("Id : {0}\tName : {1}\tFamily : {2}",PersonId,Name,Family);
        }
    }
}
