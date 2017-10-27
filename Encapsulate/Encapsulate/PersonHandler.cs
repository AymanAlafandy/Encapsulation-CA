using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
   public class PersonHandler
    {
        public void SetAge(Person per, int age)     //we do this to change the age att person class
        {
            per.Age = age;
        }
        public void SetFName(Person per, string fName)     // this is for the question 4. continue to creat methods.
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


        public int GetAge(Person per)     //we do this to change the age att person class
        {
            return per.Age;
        }
        public string GetFName(Person per)     // this is for the question 4. continue to creat methods.
        {
            return per.FName;
        }
        public string GetLName(Person per)
        {
            return per.LName;
        }
        public double GetHeight(Person per)
        {
            return per.Height;
        }
        public double GetWeight(Person per)
        {
            return per.Weight;
        }

        public Person Creatperson(int age, string fName, string lName, double height, double weight) // it does not matter the name because it is another scop.
        {
            Person bob = new Person();  //creating an instanse of person
            bob.Age = age;
            bob.FName = fName;
            bob.LName = lName;
            bob.Height = height;
            bob.Weight = weight;
            return bob;
        }

        public string PrintPerson (Person per)
        {
            return "Name: " + per.FName + " " + per.LName +
                "\nAge: " + per.Age + "\nHeight: " + per.Height + "\nWeight: " + per.Weight;
        }
    }
}
