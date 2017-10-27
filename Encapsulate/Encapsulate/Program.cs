using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonHandler ph = new PersonHandler();
            List<Person> personlst = new List<Person>();

            personlst.Add(ph.CreatePerson(18, "Billy", "Cesae", 280, 178));
            personlst.Add(ph.CreatePerson(90, "Karl", "jhoahnss", 80, 138));
            personlst.Add(ph.CreatePerson(8, "Richarf", "O'lamp", 28, 70));
            personlst.Add(ph.CreatePerson(105, "Old", "Man", 55, 160));
            personlst.Add(ph.CreatePerson(37, "Tet", "Hobla", 55, 160));

            foreach(Person p in personlst)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }

            Console.ReadLine();
        }
    }
}
