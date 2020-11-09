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
            
        }

        public override void update()
        {
            if(up)
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
