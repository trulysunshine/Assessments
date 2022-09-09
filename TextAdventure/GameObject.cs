using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal abstract class GameObject
    {
        protected int xPosition;
        protected int yPosition;

        public abstract void Draw();
    }
}
