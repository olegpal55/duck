using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("Мандариновая уточка");
        }
    }
}
