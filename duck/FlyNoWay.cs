using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Я не лечу");
        }
    }
}
