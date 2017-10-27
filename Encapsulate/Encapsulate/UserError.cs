using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public abstract class UserError
    {
        //everytime one inherits from this abstract class, they will get exactly as below.  Cannot be changed in other class.        
        //3.4.2
        public abstract string UEMessage();
    }
}
