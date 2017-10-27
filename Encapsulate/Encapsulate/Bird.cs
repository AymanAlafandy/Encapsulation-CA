using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
   public class Bird : Animal
    {
        public int SingingDb{ get; set; }

        public Bird():base() { }// you can control your information 

        public Bird( bool IsCarnivore, int age, string species, int singingDb) : // local variable
            base(IsCarnivore, age, species)//this order is important 
        {
            SingingDb = singingDb;
        }
    }
}
