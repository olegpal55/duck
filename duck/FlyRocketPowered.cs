using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Я лечу на реактивной тяге");
        }
    }
}
