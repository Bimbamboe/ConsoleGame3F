using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ConsoleGame3F
{
    class Enemy : Entity
    {
        int type;

        public Enemy()
        {
            pos(new Random().Next(), 0);
            type = new Random().Next(2);
        }

        public override void update()
        {
            if(type == 0)
            {

            }
            if (type == 1)
            {

            }
            if (type == 2)
            {

            }
        }
    }
}
