using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public void Display()
        {
            Console.WriteLine($"Displaying Model Duck");
        }
    }
}
