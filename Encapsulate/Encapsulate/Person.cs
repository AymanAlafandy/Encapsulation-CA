using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Person
    {

        //FIELDS
        private int _age;
        //
        private string _fName;
        //
        private string _lName;
        //
        private double _height;
        //
        private double _weight;
        
        
        //PROPS
        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }
        //
        public string FName
        {
            set { _fName = value; }
            get { return _fName; }
        }
        //
        public string LName
        {
            set { _lName = value; }
            get { return _lName; }
        }
        //
        public double Height
        {
            set { _height = value; }
            get { return _height; }
        }
        //
        public double Weight
        {
            set { _weight = value; }
            get { return _weight; }
        }









    }
}
