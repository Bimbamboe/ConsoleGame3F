using ConsoleGame3F;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleGame3F
{
    class Program
    {
        public static List<Entity> entities = new List<Entity>();

        static void Main(string[] args)
        {
            int timer = 0;

            Player player = new Player();

            Console.Clear();
            Console.CursorVisible = false;

            while (true)
            {
                if(timer % 60 == 0)
                {
                    Enemy en = new Enemy();
                    entities.Add(en);
                }

                for (int i = 0; i < entities.Count; i++)
                {
                    Entity e = entities[i];

                    player.draw();
                    e.draw();
                }

                System.Threading.Thread.Sleep(50);

                for(int i = 0; i < entities.Count; i++)
                {
                    Entity e = entities[i];

                    player.undraw();
                    e.undraw();

                    player.update();
                    e.update();
                }

                timer++;
            }
        }
    }
}