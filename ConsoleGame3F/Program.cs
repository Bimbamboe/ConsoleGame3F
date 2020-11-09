using ConsoleGame3F;
using System;
using System.Collections;
using System.Collections.Generic;

namespace myfirstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entity> entities = new List<Entity>();
            Player player = new Player();

            entities.Add(player);

            Console.Clear();
            Console.CursorVisible = false;
            while (true)
            {
                Console.SetCursorPosition(player.x, Console.WindowHeight);
                Console.Write("P");
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(player.x, Console.WindowHeight);
                Console.Write(" ");

                for(int i = 0; i < entities.Count; i++)
                {
                    Entity e = entities[i];
                    e.update();
                }

            }
        }
    }
}