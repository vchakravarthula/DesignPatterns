using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    internal class FlyNoWay : IFlyBehaviour
    {
        public string Name => throw new NotImplementedException();

        public void Fly()
        {
            Console.WriteLine($"I can't fly");
        }
    }
}
