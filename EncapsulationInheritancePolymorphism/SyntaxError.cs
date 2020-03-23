using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class SyntaxError : UserError
    {
        public override string UEMessage() => "Syntax error, please learn how to spell!";
    }
}
