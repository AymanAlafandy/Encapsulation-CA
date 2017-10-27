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
            personList.Add(ph.Creatperson(18, "Billy", "Ceaser", 170, 280));
            personList.Add(ph.Creatperson(25, "Samantha", "Larsson", 170, 69));
            personList.Add(ph.Creatperson(33, "Jack", "Papadimitriou", 180, 90));
            personList.Add(ph.Creatperson(29, "Pia", "Andersson", 168, 64));

            foreach(Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadLine();



        }
    }
}
