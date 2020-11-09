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
            int timer = 0;

            List<Entity> entities = new List<Entity>();
            Player player = new Player();

            entities.Add(player);

            entities.Add(new Enemy());

            Console.Clear();
            Console.CursorVisible = false;
            while (true)
            {
                if(timer % 10 == 0)
                {
                    Enemy en = new Enemy();
                    entities.Add(en);
                }

                for (int i = 0; i < entities.Count; i++)
                {
                    Entity e = entities[i];
                    e.draw();
                }

                System.Threading.Thread.Sleep(100);

                for(int i = 0; i < entities.Count; i++)
                {
                    Entity e = entities[i];
                    e.update();
                }

                timer++;
            }
        }
    }
}