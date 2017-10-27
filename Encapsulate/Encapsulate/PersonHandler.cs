using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class PersonHandler
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
            per.Lname = lName;
        }
        public void SetHeight(Person per, double height)
        {
            per.Height = height;
        }
        public void SetWeight(Person per, double weight)
        {
            per.Weight = weight;
        }
public int GetAge(Person per)
        {
            return per.Age;
        }
        public string GetFName(Person per)
        {
            return per.FName;
        }
        public string GetLName(Person per)
        {
            return per.Lname;
        }
        public double GetHeight(Person per)
        {
            return per.Height;
        }
        public double GetWeight(Person per)
        {
            return per.Weight;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person bob = new Person();
            bob.Age = age;
            bob.FName = fName;
            bob.Lname = lName;
            bob.Height = height;
            bob.Weight = weight;
            return bob;

        }

        public string PrintPerson(Person per)
        {
            return "Name:  "+ per.FName + " " +per.Lname + "\nAge : " + per.Age +  " " + "\nHeight: " + per.Height + "\nWeight: " + per.Weight;
        }
    }

   
}
