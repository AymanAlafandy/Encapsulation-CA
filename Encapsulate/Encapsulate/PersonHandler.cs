using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class PersonHandler
    {
        public void SetAge(Person per, int age)
        {
            per.Age = age;
        }
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

        // It is not recommanded to set default values)
        //public Person CreatePerson(int age, string fName, string lName, double height=170.7, double weight=79)
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

        public string PrintPerson(Person per)
        {
            return "Name: " + per.FName + " " + per.LName + "\nAge: " + per.Age + "\nHeight: " + per.Height + "\nWeight: " + per.Weight;
        }
    }
}
