using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class DatabaseError : UserError
    {
        public override string UEMessage() => "Database overload, please restart server";
    }
}
