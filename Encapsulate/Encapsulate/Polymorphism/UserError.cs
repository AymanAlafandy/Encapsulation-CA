using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public abstract class UserError
    {
        public abstract string UEMessage(); //abstract contain incompete function

        public int ErrorCode; //abstract contain normal field, property

        public virtual string King() //abstract contain normal function
        {
            return "aaaa";
        } 


    }
}
