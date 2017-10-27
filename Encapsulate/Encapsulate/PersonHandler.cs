using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public  class PersonHandler
    {

        public void Setage (Person per, int age)
        {
            per.Age = age;
        }
        public void SetName(Person per, string fName)
        {
            per.Fname =fName;
        }
        public void SetLame(Person per, string lName)
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



        public int Getage (Person per, int age)
        {
            return per.Age;
        }
        public string GetName(Person per, string fname)
        {
            return per.Fname;
        }
        public string GetlName(Person per, string lname)
        {
            return per.Lname;
        }
        public double GetHeight(Person per, double height)
        {
            return per.Height;
        }
        public double GetWeight (Person per, double weight)
        {
            return per.Weight;
        }

        public Person CreatePerson (int age,string fName,string lName,double height, double weight)

        {
            Person pears = new Person();
            pears.Age = age;
            pears.Fname = fName;
            pears.Lname = lName;
            pears.Height = height;
            pears.Weight = weight;
            return pears;
        }

        public string PrintPerson(Person per)
        {
            return "Name :" + per.Fname + " " + per.Lname + "Age :" + per.Age + "Height :" + per.Height + "Weight :" + per.Weight;

        }
    }
}
