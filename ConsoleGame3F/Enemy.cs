using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ConsoleGame3F
{
    class Enemy : Entity
    {
        public Enemy()
        {
            Random rand = new Random();
            pos(new Random().Next(), 0);
        }
    }
}
