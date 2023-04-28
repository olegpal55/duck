using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    class RubberDuck : Duck
    {
         public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
         public override void display()
        {
            Console.WriteLine("Я Резиновая уточка");
        }
    }
}
