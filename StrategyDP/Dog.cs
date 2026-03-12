using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class Dog : Animal
    {
        public string Name { get; set; }
        public Dog(string name) { this.Name = name; }

        public Dog() { }
        public override void MakeSound()
        {
            Console.WriteLine($" barks.");
        }
    }
}
