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
            

            personList.Add(ph.CreatePerson(lName:"Ceasar", fName:"Billy", age: 18, weight:  280,height: 170));
            personList.Add(ph.CreatePerson(90,"Karl", "Ceasar", 190, 70));
            personList.Add(ph.CreatePerson(8, "Ricard", "O'lamp",weight: 80));
            personList.Add(ph.CreatePerson(180, "Old", "Man", 130, 60));
            personList.Add(ph.CreatePerson(37, "Brark", "Hoblama", 190, 110));

            foreach(Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadLine();

        }
    }
}
