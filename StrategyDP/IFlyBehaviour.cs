using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public interface IFlyBehaviour
    {
        string Name { get; }

        public void Fly();
    }
}
