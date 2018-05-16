using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caps.src.GameObjects.Interfaces;

namespace Caps.src.GameObjects
{
    class Being : GameObject, IMove, IConsumer, IReproduct
    {
        int[] position;
        public int life;
        private GameObject consumeObject;

        public void Move()
        {

        }

        public void Consume(GameObject consumeObject)
        {

        }

        public Being Reproduct(Being papa, Being mama)
        {
            var result = new Being();
            return result;
        }
    }
}
