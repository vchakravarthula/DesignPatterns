using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class Cat : Animal
    {
        public string Name { get; set; }

        public Cat() { }
        public Cat(string name) { this.Name = name; }

        public override void MakeSound()
        {
            Console.WriteLine($"meows.");
        }
    }
}
