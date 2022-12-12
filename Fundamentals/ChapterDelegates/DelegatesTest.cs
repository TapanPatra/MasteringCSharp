using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class DelegatesTest
    {
        [Test]
        public void SingleInterfaceMethod()
        {
            IInt32Action action = new Delegates();
            action.DoIt(10);
        }

        [Test]
        public void SimpleDelegateFromMethod()
        {
            Delegates target = new Delegates("Tapan");
            Int32Action action = new Int32Action(target.RandomDoIt);

            action.Invoke(20);
        }

        [Test]
        public void DelegateFromStaticMethod()
        {
            Int32Action action = new Int32Action(Delegates.Static1DoIt);
            action.Invoke(30);
        }

        [Test]
        public void MulticastDelegate()
        {
            Int32Action action1 = new Int32Action(Delegates.Static1DoIt);
            Int32Action action2 = new Int32Action(Delegates.Static2DoIt);

            Int32Action action3 = action1 + action2;
            //Int32Action action3 = (Int32Action)Delegate.Combine(action1, action2);
            action3.Invoke(20);

        }

    }
}
