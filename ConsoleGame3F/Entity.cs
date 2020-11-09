﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame3F
{
    abstract class Entity
    {
        public int x, y;
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

        public void shoot()
        {

        }
    }
}
