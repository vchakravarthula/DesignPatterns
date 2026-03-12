using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class Squeak : IQuackBehaviour
    {
        public string Name { get; private set; }
        public Squeak(string name)
        {
            this.Name = name;
        }
        public Squeak()
        {
        }
        public void Quack()
        {
            Console.WriteLine($"Squeak!");
        }
    }
}
