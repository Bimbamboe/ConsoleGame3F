using ConsoleGame3F;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleGame3F
{
    class Program
    {
        public static List<Entity> entities = new List<Entity>();

        public static bool game = true;

        static void Main(string[] args)
        {
            int timer = 0;

            Player player = new Player();

            entities.Add(player);

            Console.Clear();
            Console.CursorVisible = false;

            while (game)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Life: " + player.life);

                if (timer % 60 == 0)
                {
                    Enemy en = new Enemy();
                    entities.Add(en);
                }

                for (int i = 0; i < entities.Count; i++)
                {
                    Entity e = entities[i];
                    e.draw();
                }

                System.Threading.Thread.Sleep(50);

                Console.SetCursorPosition(0, 0);
                Console.Write(" ");

                for (int i = 0; i < entities.Count; i++)
                {
                    Entity e = entities[i];
                    e.undraw();
                    e.update();

                    if (e is Enemy || e is Bullet)
                    {
                        if (e.x == player.x && e.y == player.y)
                        {
                            player.life--;
                            entities.Remove(e);

                            if (player.life == 0)
                            {
                                game = false;
                            }
                        }
                    }

                    if (e is Bullet)
                    {
                        for (int q = 0; q < entities.Count; q++)
                        {
                            Entity entity = entities[q];
                            if(entity is Enemy)
                            {
                                if (e.x == entity.x && e.y == entity.y)
                                {
                                    entities.Remove(entity);
                                    entities.Remove(e);
                                }
                            }
                            
                        }
                    }
                }

                timer++;
            }
        }
    }
}