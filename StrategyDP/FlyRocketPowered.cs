using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class FlyRocketPowered : IFlyBehaviour
    {
        public string Name { get; private set; }
        public FlyRocketPowered()
        {
        }
        public void Fly()
        {
            Console.WriteLine($"I'm flying with a rocket!");
        }
    }
}
