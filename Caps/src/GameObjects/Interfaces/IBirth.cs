using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caps.src.GameObjects.Interfaces
{
    interface IBirth
    {
        int period { get; set; }

        Being Birth(Being papa, Being mama);
    }
}
