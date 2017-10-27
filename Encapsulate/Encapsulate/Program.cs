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
            List<Person> personlist = new List<Person>();

            personlist.Add(ph.CreatePerson(18, "Ayman0", "Alaafandy0", 178, 80));
            personlist.Add(ph.CreatePerson(19, "Ayman1", "Alaafandy1", 179, 81));
            personlist.Add(ph.CreatePerson(20, "Ayman2", "Alaafandy2", 180, 82));
            personlist.Add(ph.CreatePerson(21, "Ayman3", "Alaafandy3", 181, 83));
            personlist.Add(ph.CreatePerson(22, "Ayman4", "Alaafandy4", 182, 84));

            foreach (Person p in personlist)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }



            Console.ReadLine();
        }
    }
}
