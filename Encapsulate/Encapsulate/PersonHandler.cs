using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class PersonHandler
    {
        //3.1.2
        public void SetAge(Person per, int age) //Method to change a person's age.
        {
            per.Age = age;
        }

        //3.1.4 Creating more methods for stuff to do with a person.
            //Setting variables ... we can use void cause we dont need to return anything.
        public void SetFName(Person per, string fName)
        {
            per.FName = fName;
        }

        public void SetLName(Person per, string lName)
        {
            per.LName = lName;
        }

        public void SetHeight(Person per, double height)
        {
            per.Height = height;
        }

        public void SetWeight(Person per, double weight)
        {
            per.Weight = weight;
        }

            //Getting variables ... we use int and string return types cause we want to return values.
        public int GetAge(Person per, int age) 
        {
            return per.Age;
        }

        public string GetFName(Person per, string fName)
        {
            return per.FName;
        }

        public string GetLName(Person per, string lName)
        {
            return per.LName;
        }

        public double GetHeight(Person per, double height)
        {
            return per.Height;
        }

        public double GetWeight(Person per, double weight)
        {
            return per.Weight;
        }



        //3.1.3
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person bob = new Person();
            bob.Age = age;
            bob.FName = fName;
            bob.LName = lName;
            bob.Height = height;
            bob.Weight = weight;

            return bob;
        }

        //3.1.4 //Printing out persons' details
        public string PrintPerson(Person per)
        {
            return "Name: " + per.FName + " " + per.LName +
                "\nAge: "+ per.Age + "\nHeight: " + per.Height +
                "\nWeight: "+ per.Weight;   
        }

    }

}
