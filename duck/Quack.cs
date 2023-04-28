using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Кря-Кря");
        }
    }
}
