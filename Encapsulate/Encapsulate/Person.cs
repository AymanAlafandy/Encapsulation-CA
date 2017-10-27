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
        private string fName; //declaring the variable with f and V camel case it is to initating variables or otherthing that's private(sometimes private fields name containe under dash)
        private string lName;  
        private double height;
        private double weight;

        public int Age { get { return age; } set { age = value; } }             //bascal case  used to to named properities
        public string FName { get { return fName; } set { fName = value; } }
        public string LName { get { return lName; } set { lName = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
    }
}
