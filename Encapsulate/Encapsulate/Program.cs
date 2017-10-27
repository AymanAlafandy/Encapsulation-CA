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
            personList.Add(ph.CreatePerson(18, "moshen", "Ahmed", 170, 240));
            personList.Add(ph.CreatePerson(18, "moshena", "nabira", 170, 240));
            personList.Add(ph.CreatePerson(18, "mounira", "seramulira", 170, 240));
            personList.Add(ph.CreatePerson(18, "nagawa", "Asha", 78, 70));

            foreach (var p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
        }
    }
}
