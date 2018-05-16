using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caps.src.GameObjects.Interfaces;

namespace Caps.src.GameObjects
{
    abstract class GameObject : IGameObject
    {
        public virtual void Pin()
        {
            Console.WriteLine("Base Pin");
        }
    }
}
