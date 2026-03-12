using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public abstract class Duck
    {
        public IQuackBehaviour quackBehavior;
        public IFlyBehaviour flyBehavior;
        public string Name { get; set; }
        public Duck(string name) { this.Name = name; }
        public Duck() { }
        public virtual void Display()
        {
            Console.WriteLine($"Displaying");
        }

        public void SetQuackBehavior(IQuackBehaviour qb)
        {
            quackBehavior = qb;
        }

        public void SetFlyBehavior(IFlyBehaviour fb)
        {
            flyBehavior = fb;
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine($"Swimming");
        }
    }
}
