using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
   public class DerivedClass : BaseClass
    {

        public DerivedClass() : base ("derived default")
        {

        }

        public DerivedClass(string name) : base ("derived " + name)
        {

        }

        public override int CalculateResult(int x)
        {
            return x / 2;
        }

        public int QuadarapleInput(int x)
        {
            return x * 4;
        }
    }
}
