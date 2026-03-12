using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class FlyWithWings : IFlyBehaviour
    {
        public string Name { get; private set; }
        public FlyWithWings(string name)
        {
            this.Name = name;
        }
        public FlyWithWings()
        {
        }

        public void Fly()
        {
            Console.WriteLine($"I'm flying with wings!");
        }
    }
}
