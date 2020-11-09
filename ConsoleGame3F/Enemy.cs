using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ConsoleGame3F
{
    class Enemy : Entity
    {
        int type;

        int slow = 0;
        int shoottimer = 60;

        public Enemy()
        {
            pos(new Random().Next(Console.WindowWidth), 0);
            type = new Random().Next(2);
        }

        public override void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("E");
        }

        public override void update()
        {
            if (outofbounds())
            {
                undraw();
                Program.entities.Remove(this);
            }


            if (type == 0)
            {
                if (shoottimer == 60)
                {
                    shoot(false);
                    shoottimer = 0;
                }
                shoottimer++;
            }

            if (type == 1)
            {
                
                Random r = new Random();
                if (r.Next(2) == 1)
                {
                    
                    //right();
                }
                else
                {
                    //left();
                }
            }

            if (type == 2)
            {
                if(shoottimer == 12)
                {
                    shoot(false);
                    shoottimer = 0;
                }
                shoottimer++;
            }

            if(slow == 6)
            {
                down();
                slow = 0;
            }
            slow++;
        }
    }
}
