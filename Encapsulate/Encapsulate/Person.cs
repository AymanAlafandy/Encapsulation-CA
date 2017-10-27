using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double weight;
        private double height;          

        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }


        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
