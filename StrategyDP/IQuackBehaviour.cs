using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public interface IQuackBehaviour
    {
        string Name { get; }

        public void Quack();
    }
}
