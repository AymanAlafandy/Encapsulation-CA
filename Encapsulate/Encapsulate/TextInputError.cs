using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. \nThis fired an error!";
        }
    }
}
