using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caps.src.GameObjects.Interfaces;

namespace Caps.src.GameObjects
{
    class Being : GameObject, IMove, IConsumer, IRelationships, IBirth
    {
        int[] position;
        public int life;
        private GameObject consumeObject;

        Being(int[] position, int life)
        {
            this.life = life;
            this.position = position;
        }

        public void Move()
        {

        }

        public void Consume(GameObject consumeObject)
        {

        }

        public bool MakeSense(Being papa, Being mama)
        {
            bool result = true; //findAPartner();
            return result;
        }

        public Being Birth(Being papa, Being mama)
        {
            int[] position = { 10, 10 };// getPosition()
            int life = 100; // getLife()

            var result = new Being(position, life);
            return result;
        }
    }
}
