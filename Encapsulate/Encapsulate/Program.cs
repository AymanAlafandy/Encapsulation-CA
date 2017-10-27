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
            List<Person> personList = new List<Person>();
            personList.Add(ph.CreatePerson(18, "Billy", "Ceaser", 170, 280));
            personList.Add(ph.CreatePerson(33, "Bhanu", "vakamalla", 150, 58));
            personList.Add(ph.CreatePerson(36, "Sai", "Bodimallu", 170, 70));
            personList.Add(ph.CreatePerson(5, "Tanishca", "Bodimallu", 120, 25));
            personList.Add(ph.CreatePerson(1, "Varnica", "Bodimallu", 80, 12));

            foreach  (Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }

            Console.ReadLine();
        }
    }
}
