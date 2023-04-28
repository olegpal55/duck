using System;
using System.Collections.Generic;
using System.Text;

namespace duck
{
    class MuteQuack : QuackBehavior
    {
        public void quack()
        {
        Console.WriteLine(".........");
        }

    }
}
