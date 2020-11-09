using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame3F
{
    class Bullet : Entity
    {
        //0 = down | 1 = up
        bool up;

        public Bullet(bool up)
        {
            this.up = up;
        }

        public override void draw()
        {
            if(!(y < 0 || y >= Console.WindowHeight)) {
                Console.SetCursorPosition(x, y);
                Console.Write(".");
            }
            
        }

        public override void update()
        {
            if (y == 0 || y == Console.WindowHeight)
            {
                undraw();
                Program.entities.Remove(this);
            }

            if (up)
            {
                up();
            }
            else
            {
                down();
            }
        }
    }
}
