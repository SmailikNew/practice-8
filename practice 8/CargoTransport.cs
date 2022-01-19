using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_8
{
    interface CargoTransport : Ship
    {
        int LoadCapacity { get; set; }
    }
}
