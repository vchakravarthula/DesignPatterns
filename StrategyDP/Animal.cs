using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine($"makes a sound.");
        }
    }
}
