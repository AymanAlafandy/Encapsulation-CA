using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class Person
    {
        private int age;
        private String fName;
        private double height;
        private double weight;
        private string lname;

        public int Age { get { return age; } set { age = value; } }
        public string FName { get { return fName; } set {fName = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
    }
}
