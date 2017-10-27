using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler ph = new PersonHandler();
            List<Person> personlist = new List<Person>();


            personlist.Add(ph.CreatePerson(76, "KN", "Singh", 160, 75));
            personlist.Add(ph.CreatePerson(33, "Girija", "Singh", 159, 70));
            personlist.Add(ph.CreatePerson(37, "Rahul", "Singh", 171, 65));
            personlist.Add(ph.CreatePerson(37, "Tamanna", "Singh", 165, 72));
            personlist.Add(ph.CreatePerson(33, "Kunal", "Singh", 182, 96));
            personlist.Add(ph.CreatePerson(fName: "Ishaan",lName: "Singh",age: 1, height: 36, weight: 10));// A way to re-order the signature as defined in the method.
            

            foreach (Person p in personlist)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadLine();
        }
    }
}
