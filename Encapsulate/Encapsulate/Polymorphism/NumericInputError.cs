using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "NumericInputError";
        }
    }
}
