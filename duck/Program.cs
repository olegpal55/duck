using System;

namespace duck
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck1 = new MallardDuck();
            duck1.display();
            duck1.swim();
            duck1.performQuack();
            duck1.perfomFly();

            RedheadDuck duck2 = new RedheadDuck();
            duck2.display();
            duck2.swim();
            duck2.performQuack();
            duck2.perfomFly();
            duck2.setFlyBehavior(new FlyRocketPowered());
            duck2.perfomFly();

            RubberDuck duck3 = new RubberDuck();
            duck3.display();
            duck3.swim();
            duck3.performQuack();
            duck3.perfomFly();

            HomeDuck duck4 = new HomeDuck();
            duck4.display();
            duck4.swim();
            duck4.performQuack();
            duck4.perfomFly();



        }
    }
}
