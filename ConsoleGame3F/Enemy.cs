using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ConsoleGame3F
{
    class Enemy : Entity
    {
        int type;

        public Enemy()
        {
            pos(new Random().Next(), 0);
            type = new Random().Next(2);
            x = new Random().Next(Console.WindowWidth);
            y = 0;  
        }

        public override void update()
        {
            if(type == 0)
            {
                down();
            }
            if (type == 1)
            {
                down();
                Random r = new Random();
                if (r.Next(2) == 1)
                {
                    right();
                }
                else
                {
                    left();
                }
            }
            if (type == 2)
            {
                down();
            }
        }
    }
}
