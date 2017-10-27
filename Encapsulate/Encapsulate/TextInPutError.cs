using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class TextInPutError :UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numerical ony field, This fired and error";
        }
    }
}
