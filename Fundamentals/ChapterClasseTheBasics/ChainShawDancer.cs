using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public sealed class ChainShawDancer : IControllable
    {
        public void Start()
        {
            Console.WriteLine("Starting Dance");
            Console.WriteLine("Brim Brim Brim");
        }

        public void Stop()
        {
            Console.WriteLine("thid thud thud");
        }
    }
}
