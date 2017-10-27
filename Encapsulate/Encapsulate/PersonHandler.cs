using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
  public  class PersonHandler
    {

        public void SetAge(Person pers, int age) // set void to SetAge because we will not return anything
        {
            pers.Age = age; // use age para of the Person
        }

        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName; 
        }
        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height; 
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight; 
        }


        public int GetAge(Person pers)
        {
            return pers.Age;  // use age para of the Person
        }

        public string GetFName(Person pers)
        {
            return pers.FName;
        }
        public string GetLName(Person pers)
        {
             return pers.LName;
        }
        public double GetHeight(Person pers)
        {
            return pers.Height ;
        }

        public double GetWeight(Person pers)
        {
            return pers.Weight;
        }



        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {

            Person bob = new Person();  // create 
            bob.Age = age;
            bob.FName = fName;
            bob.LName = lName;
            bob.Height = height;
            bob.Weight = weight;


            return bob;

        }
        public string PrintPerson(Person per)
        {
            return "Name:" + per.FName + " " + per.LName +
                "\nAge: " + per.Age + "\nHeight:" + per.Height +
                "\nWeight: " + per.Weight;
        }
        }
    }

