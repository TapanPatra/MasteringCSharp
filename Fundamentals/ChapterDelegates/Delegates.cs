using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public delegate void Int32Action(int value);

    public interface IInt32Action
    {
        void DoIt(int value);
    }
    public class Delegates : IInt32Action
    {
        private  readonly string name;

        public Delegates() : this("unknown")
        {

        }

        public Delegates(string name)
        {
            this.name = name;
        }
        public void DoIt(int value)
        {
            Console.WriteLine("interface implementation : {0}", value);
        }

        public void RandomDoIt(int value)
        {
            Console.WriteLine("{0} : Delegate implementation : {1} ", name, value);
        }

        public static void Static1DoIt(int value)
        {
            Console.WriteLine("static 1 implementation : {0}", value);
        }

        public static void Static2DoIt(int value)
        {
            Console.WriteLine("static 2 implementation : {0}", value);

        }
    }
}
