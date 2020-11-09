using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame3F
{
    class Player : Entity
    {
        public int life = 3;

        public Player()
        {
            pos(Console.WindowWidth / 2, Console.WindowHeight);
        }

        public override void update()
        {

            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key.Equals(ConsoleKey.A))
                {
                    left();
                }
                if (key.Equals(ConsoleKey.D))
                {
                    right();
                }
                if (key.Equals(ConsoleKey.Spacebar))
                {
                    shoot(true);
                }
            }
        }

        public override void draw()
        {
            Console.SetCursorPosition(x, Console.WindowHeight);
            Console.Write("P");
        }


    }
}
