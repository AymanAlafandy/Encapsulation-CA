using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class NumericInputError : UserError
    {
        //3.4.4
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. \nThis fired an error!";
        }
    }
}
