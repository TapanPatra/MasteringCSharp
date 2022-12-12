using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class TapDancer : Dancer
    {

        public TapDancer() : base("tap dancer")
        {

        }

        public override void Dance()
        {
            Console.WriteLine("Drip, Drip");
        }

        public override void Stop()
        {
            Console.WriteLine("ddddd ddddd");
        }
    }
}
