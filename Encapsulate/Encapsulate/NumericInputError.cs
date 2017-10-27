using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class NumericInputError: UserError 
    {
        public override string UEMessage()
        {
        return "You tried to use a \nnumeric input in a text only field.\n This fired an error!";
        }
    }
}
