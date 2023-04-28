using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    abstract class Duck
    {
        protected FlyBehavior flyBehavior;

        public void perfomFly() 
        {
            flyBehavior.Fly();
        }
        public void setFlyBehavior(FlyBehavior fb) {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb){
            quackBehavior = qb;
        }
        protected QuackBehavior quackBehavior;
        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim() 
        {
            Console.WriteLine("я плыву");
        }

        public abstract void display();
    }
}
    