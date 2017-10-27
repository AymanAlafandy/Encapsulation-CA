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
            //3.1.5
            PersonHandler ph = new PersonHandler();
            List<Person> personList = new List<Person>();

            personList.Add(ph.CreatePerson(18, "Billy", "Ceasar", 170, 280));
            personList.Add(ph.CreatePerson(19, "Johnny", "Cash", 171, 180));
            personList.Add(ph.CreatePerson(20, "Niki", "Minaj", 172, 190));
            personList.Add(ph.CreatePerson(21, "Miley", "Cyrus", 173, 200));
            personList.Add(ph.CreatePerson(22, "Justin", "Timberlake", 174, 210));

            foreach(Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadLine();

        }
    }
}
