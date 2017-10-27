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

            personList.Add(ph.CreatePerson(lName: "Ceasar", fName: "Billy", age: 18, weight: 280, height: 170));
            personList.Add(ph.CreatePerson(90, "Karl", "Ceasar", 190, 70));
            personList.Add(ph.CreatePerson(8, "Ricard", "O'lamp", weight: 80));
            personList.Add(ph.CreatePerson(180, "Old", "Man", 130, 60));
            personList.Add(ph.CreatePerson(37, "Brark", "Hoblama", 190, 110));

            foreach (Person p in personList)
            {
                Console.WriteLine(ph.PrintPerson(p));
            }
            Console.ReadLine();

            Console.Clear();
            List<Animal> animals = new List<Animal>();
            Horse horsy = new Horse(true, 3000, "Devil Horse", true);
            Dog doggy = new Dog(false, 4, "Doper-man", 0);
            Pelican pelly = new Pelican(true, 10, "flappy-big-mouth", 120, true);
            Swan rageMonster = new Swan(true, 90000000, "white-hot-rage", 300, 239);
            animals.Add(horsy);
            animals.Add(doggy);
            animals.Add(pelly);
            animals.Add(rageMonster);



            List<Dog> dogs = new List<Dog>();
            Dog doggy2 = new Dog(true, 12, "Wolf", 10);
            Dog doggy3 = new Dog(false, 7, "Poodle", 3);
            dogs.Add(doggy);
            dogs.Add(doggy2);
            dogs.Add(doggy3);
            animals.Add(doggy3);

            //3.3.5 Print out types of animals
            foreach (Animal a in animals)
            {
                Console.WriteLine(a.GetType().Name);
            }
            Console.ReadLine();
            Console.Clear();

            //3.3.9 Print out list of animals
            foreach (Animal a in animals)
            {
                Console.WriteLine(a.Stats());
            }
            Console.ReadLine();
            Console.Clear();

            //3.3.11 Print out only dogs from animal list
            foreach (Animal a in animals)
            {
                if (a.GetType().Name == "Dog")
                {
                    Console.WriteLine(a.Stats());
                }
            }
            Console.ReadLine();
            Console.Clear();


            //Will print out only Dogs
            foreach (Animal a in animals.OfType<Dog>())
            {
                Console.WriteLine(a.Stats());
            }


            //3.3.14. Soft cast ((Dog)a) allows us to select functions from child class
            foreach (Animal a in animals)
            {
                if (a.GetType().Name == "Dog")
                {
                    Console.WriteLine(a.Stats() + "\n" +
                        ((Dog)a).Speak() + "\n");
                }
                else
                {
                    Console.WriteLine(a.Stats());
                }
            }
            Console.ReadLine();
            Console.Clear();




        }
    }
}
