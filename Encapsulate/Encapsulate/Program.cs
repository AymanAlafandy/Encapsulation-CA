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

            //PersonHandler ph = new PersonHandler();
            //List<Person> personList = new List<Person>();

            //personList.Add(ph.CreatePerson(lName:"Ceasar", fName:"Billy", age: 18, weight:  280,height: 170));
            //personList.Add(ph.CreatePerson(90,"Karl", "Ceasar", 190, 70));
            //personList.Add(ph.CreatePerson(8, "Ricard", "O'lamp",weight: 80));
            //personList.Add(ph.CreatePerson(180, "Old", "Man", 130, 60));
            //personList.Add(ph.CreatePerson(37, "Brark", "Hoblama", 190, 110));


            //foreach(Person p in personList)
            //{
            //    Console.WriteLine(ph.PrintPerson(p));
            //}
            //Console.ReadLine();

            List<Animal> animals = new List<Animal>();
            Horse horsy = new Horse(true, 3000, "Devil Dog", true);
            Dog Doggy = new Dog(false, 4, "doper-Man", 200000);
            Pelican pely = new Pelican(false, 10, "Flappy", 200, true);
            Swan swanny = new Swan(true, 9000000, "white hot rage", 300, 239);

            animals.Add(horsy);
            animals.Add(Doggy);
            animals.Add(pely);
            animals.Add(swanny);


            foreach (var animals1 in animals)
            {
                Console.WriteLine(animals1.Stats());
              
             }
            Console.ReadLine();

            foreach (Animal a in animals)
            {
                Console.WriteLine(a.GetType().Name);
               
            }
            Console.ReadLine();

            List<Dog> dogs = new List<Dog>();
            Dog doggy1 = new Dog(true, 10, "wolf", 10);
            Dog doggy2 = new Dog(true, 3, "Lion", 110);
            Dog doggy3 = new Dog(true, 5, "Tiger", 310);

            dogs.Add(Doggy);
            dogs.Add(doggy1);
            dogs.Add(doggy2);
            dogs.Add(doggy3);

            foreach (Animal a in animals.OfType<Dog>())
            {
                if(a.GetType().Name== "Dog")
                Console.WriteLine(a.Stats());
            }


            foreach (Animal a in animals)
            {
                if (a.GetType().Name == "Dog")
                    Console.WriteLine(a.Stats()+"\n"
                        +((Dog)a).speak());

                else
                {

                    Console.WriteLine(a.Stats());

                }
            }
            Console.ReadLine();
        }
    }
}
