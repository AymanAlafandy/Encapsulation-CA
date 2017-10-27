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
            List<Person> PersonList = new List<Person>();

            PersonList.Add(ph.CreatPerson(18, "Billy", "Ceaser", 170 , 280));
            PersonList.Add(ph.CreatPerson(90, "Karl", "Ceaser", 190, 70));
            PersonList.Add(ph.CreatPerson(8, "Ricard", "o'lamp", 70, 28));
            PersonList.Add(ph.CreatPerson(180, "Old", "Man", 130, 60));
            PersonList.Add(ph.CreatPerson(37, "Brark", "Hoblama", 190, 68));
            foreach (Person p in PersonList)
            {
                Console.WriteLine(ph.PrintPerson(p));

            }
            Console.ReadLine();

        }
    }
}
