using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    class HomeDuck : Duck
    {
        public HomeDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("Я домашняя уточка");
        }
    }
}
