﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame3F
{
    abstract class Entity
    {
        public int x, y;
        
        public void pos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void left()
        {
            x = Math.Max(0, x - 1);
        }

        public void right()
        {
            x = Math.Min(Console.WindowWidth, x + 1);
        }

        public void down()
        {
            y = y + 1;
        }

        public void up()
        {
            y = y - 1;
        }

        public abstract void update();

        public abstract void draw();

        public void undraw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        public void shoot(bool up)
        {
            Bullet b = new Bullet(up);
            b.pos(x, up ? y - 1 : y + 1);
            Program.entities.Add(b);
        }

        public bool outofbounds()
        {
            if (x < 0 || x > Console.WindowWidth || y < 0 || y > Console.WindowHeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
