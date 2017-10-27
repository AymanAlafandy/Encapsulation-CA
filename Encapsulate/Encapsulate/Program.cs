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
            Console.Clear();

            List<Animal> animals = new List<Animal>();
            //Horse horsey = new Horse(true, 111, "Hor",true);
            
            Dog dogy = new Dog(false, 4, "Dpper man,0",23);
            Pelican pelicany = new Pelican(false, 11, "pel", 113, true);
            animals.Add(dogy);
            animals.Add(pelicany);

            foreach (Animal a in animals)
            {
                //Console.WriteLine(a.Stats());
                Console.WriteLine(a.GetType().Name);

            }


            Console.ReadLine();
            List<Dog> dogs = new List<Dog>();
            Dog dogy2 = new Dog(true, 10, " gogo ", 13432);
            Dog dogy3 = new Dog(false, 11, " gogojhgfd ", 1);
            Dog dogy4 = new Dog(true, 10, " fofo ", 12);

            dogs.Add(dogy2);
            dogs.Add(dogy3);
            dogs.Add(dogy4);
            animals.Add(dogy4);

            foreach (Animal a in animals)
            {
                Console.WriteLine(a.Stats());

            }
            Console.ReadLine();
            Console.Clear();

            foreach (Animal a in animals.OfType<Dog>())
            {
               
                    Console.WriteLine(a.Stats()+"\n" + ((Dog)) );           

            }
            Console.ReadLine();
            Console.Clear();

            foreach (Animal a in animals)
            {
                if (a.GetType().Name == "Dog")
                {
                    Console.WriteLine(a.Stats()+"\n"+((Dog)a).Speak()+"\n");
                }
                else
                {
                    Console.WriteLine(a.Stats() );    
                }

            }
            Console.ReadLine();
            Console.Clear();

        }
    }
}
