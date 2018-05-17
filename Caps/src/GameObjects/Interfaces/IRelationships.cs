using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caps.src.GameObjects.Interfaces
{
    interface IRelationships
    {
        bool MakeSense(Being papa, Being mama);

        //Being findAPartner();
    }
}
