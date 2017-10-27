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
            personList.Add(ph.CreatePerson(18, "Carl", "Ceasar", 175, 280));
            personList.Add(ph.CreatePerson(18, "Julle", "Ceasar", 170, 290));
            personList.Add(ph.CreatePerson(18, "Gun", "Ceasar", 160, 240));
            personList.Add(ph.CreatePerson(18, "Bill", "Ceasar", 169, 279));

            foreach (Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadKey();
        }
    }
}
