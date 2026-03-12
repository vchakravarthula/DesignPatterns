using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }
        public void Display()
        {
            Console.WriteLine($"Displaying Decoy Duck");
        }
    }
}
