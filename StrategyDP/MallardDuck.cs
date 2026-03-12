using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class MallardDuck : Duck
    {
        //public IQuackBehaviour quackBehavior;
        //public IFlyBehaviour flyBehavior;
        public MallardDuck(string name) : base(name) { }
        public MallardDuck() 
        {
            quackBehavior = new QuackBird();
            flyBehavior = new FlyWithWings();
        }
        public void Quack()
        {
            Console.WriteLine($"Mallard Quacks!");
        }

        public override void Display()
        {
            Console.WriteLine($"Displaying Mallard Duck");
        }

        public void Fly()
        {
            Console.WriteLine("Mallard can fly");
        }
    }
}
