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

            personList.Add(ph.CreatePerson(18, "Billy", "Ceasar", 170, 280));
            personList.Add(ph.CreatePerson(15, "John", "Helman", 150, 80));
            personList.Add(ph.CreatePerson(20, "Deide", "Love", 200, 70));
            personList.Add(ph.CreatePerson(25, "Iggy", "Bosa", 170, 290));
            personList.Add(ph.CreatePerson(3, "Mini", "Selly", 140, 28));

            foreach(Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadLine();
        }
    }
}
