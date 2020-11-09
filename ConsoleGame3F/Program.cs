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
            Enemy enemy = new Enemy();

            entities.Add(player);
            entities.Add(enemy);

            Console.Clear();
            Console.CursorVisible = false;
            while (true)
            {
                Console.SetCursorPosition(enemy.x, enemy.y);
                Console.Write("E");
                System.Threading.Thread.Sleep(100);
                Console.SetCursorPosition(enemy.x, enemy.y);
                Console.Write(" ");

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