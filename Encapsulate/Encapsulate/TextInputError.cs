using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class TextInputError : UserError
    {
        //3.4.6
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. \nThis fired an error!";
        }
    }
}
