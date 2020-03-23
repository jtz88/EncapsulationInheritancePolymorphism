using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class BackEndError : UserError
    {
        public override string UEMessage() => "Backend meltdown iminent, please evacuate in an orderly fashion";
    }
}
