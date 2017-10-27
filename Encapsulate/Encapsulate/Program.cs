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
            List<Person> personList = new List<Person>();
            personList.Add(ph.CreatePerson(18, "Billy", "Ceasar", 170, 280));
            personList.Add(ph.CreatePerson(90, "KARL", "Ceasar", 190, 70));
            personList.Add(ph.CreatePerson(8, "Richard", "O'lamp", 70, 28));
            personList.Add(ph.CreatePerson(180, "Old", "Man", 130, 60));
            personList.Add(ph.CreatePerson(18, "Brark", "Hoblama", 190, 110));
            personList.Add(ph.CreatePerson(81, "Brarky", "Boblama", weight: 60));

            foreach (Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadLine();
        }
    }
}
