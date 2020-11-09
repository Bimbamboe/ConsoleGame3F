using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame3F
{
    abstract class Entity
    {
        private int x, y;
        
        public void pos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void left()
        {
            x = Math.Max(0, x - 1);
        }

        public void right()
        {
            x = Math.Min(Console.WindowWidth, x + 1);
        }

        public void down()
        {
            y = y + 1;
        }

        public void shoot()
        {

        }
    }
}
