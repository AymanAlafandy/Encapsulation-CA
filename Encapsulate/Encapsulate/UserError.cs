using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public abstract class UserError
    {
        // a virtual method will always work in an abstract class!
        public virtual string Kings()
        {
          return "I BE King";
        }
        // a string method will always be usefull for testing for errors!
        public string King()
        {
            return "";
        }

        public abstract string UEMessage();
       
       
    }
}
