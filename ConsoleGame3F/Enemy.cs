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
            Console.SetCursorPosition(x, y);
            Console.Write(" ");

            if (type == 0)
            {

            }
            if (type == 1)
            {

            }
            if (type == 2)
            {

            }
            down();
        }
    }
}
