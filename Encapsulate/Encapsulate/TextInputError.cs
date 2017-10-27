using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class TextInputError:UserError
    {
        public override string UeMessage()
        {
            return "You tried to use a numeric input in a text only field.This fired an error!..";
        }

    }
}
