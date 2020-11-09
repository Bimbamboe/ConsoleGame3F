using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame3F
{
    class Player : Entity
    {
        public Player()
        {
            pos(Console.WindowWidth / 2, Console.WindowHeight);
        }

        public override void update()
        {
            Console.SetCursorPosition(x, Console.WindowHeight);
            Console.Write(" ");

            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key.Equals(ConsoleKey.J))
                {
                    left();
                }
                if (key.Equals(ConsoleKey.K))
                {
                    right();
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
