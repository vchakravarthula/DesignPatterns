using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice2
{
    public class MuteQuack : IQuackBehaviour
    {
        public string Name => throw new NotImplementedException();

        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
