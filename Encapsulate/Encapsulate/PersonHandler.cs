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
        public void SetFName(Person per, string fname)
        {
            per.FName = fname;
        }
        public void SetLName(Person per, string lname)
        {
            per.LName = lname;
        }
        public void SetWeight(Person per, double weight)
        {
            per.Weight = weight;
        }
        public void SetHeight(Person per, double height)
        {
            per.Height = height;
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
            return per.LName;
        }
        public double GetWeight(Person per)
        {
            return per.Weight;
        }
        public double Getheight(Person per)
        {
            return per.Height;
        }

        public Person CreatePerson(int age, string fname, string lname, double weight, double height)
        {
            Person per = new Person();
            per.Age = age;
            per.FName = fname;
            per.LName = lname;
            per.Height = height;
            per.Weight = weight;

            return per;
        }

        public string PrintPerson(Person per)
        {
            return "Name: " + per.FName + " " + per.LName + "\nAge: " + per.Age + "\nHeight: " + per.Height + " cm \nWeight: " + per.Weight + " kg \n";
        }
    }
}
