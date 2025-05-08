using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Collections_With_Method_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person(1,"amir","zare");

            //Console.WriteLine(person1.ToString());

            List<Person> personList = new List<Person>()
            {
                new Person(1,"amir","zare"),
                new Person(2,"arshia","zare"),
                new Person(3,"hanie","esmail"),
                new Person(4,"faeze","esmail"),
                new Person(5,"ali","taheri"),
                new Person(6,"faeze","esmail")
            };

            //Method Syntax
            var list1 = personList.Where(  t => t.Name.StartsWith("h") && t.Family.EndsWith("l")  );
            var list1 = personList.OrderBy( t => t.Name ).ThenBy( t => t.Family );
            var list1 = personList.OrderBy(t => t.Name).ThenBy(t => t.Family).ThenBy(t => t.PersonId);

            //Query Syntax
            var list1 = from t in personList
            where t.Name.StartsWith("")
            orderby t.Name ascending
            select t;

            foreach (var person in list1)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}
