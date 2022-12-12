using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterInterfaces
{
    public class Tester : IFoo, IBar
    {
        void IFoo.Execute()
        {
            Console.WriteLine("IFoo.Execute()");
        }

        void IBar.Execute()
        {
            Console.WriteLine("IBar.Execute()");
        }

        public void Execute()
        {
           ((IBar) this).Execute();
        }
    }
}
