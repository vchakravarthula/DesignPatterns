using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class QuackBird : IQuackBehaviour
    {
        public string Name { get; private set; }
        public QuackBird(string name)
        {
            this.Name = name;
        }
        public QuackBird()
        {           
        }

        public void Quack()
        {
            Console.WriteLine($"Quack!");
        }
    }
}
