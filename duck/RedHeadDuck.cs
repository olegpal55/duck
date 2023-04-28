using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
            
        }
         public override void display()
        {
            Console.WriteLine("Я красноголовая уточка");
        }
    }
}
