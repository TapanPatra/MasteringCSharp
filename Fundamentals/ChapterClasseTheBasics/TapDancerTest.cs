using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class TapDancerTest
    {
        [Test]
        public void DefaultName()
        {
            Dancer dancer = new TapDancer();
            Assert.AreEqual("tap dancer", dancer.Name);        
        }

        [Test]
        public void DanceByDance()
        {
            Dancer dancer = new TapDancer();
            dancer.Dance();
        }

        [Test]
        public void DanceTwice()
        {
            Dancer dancer = new TapDancer();
            dancer.DanceTwice();
        }
    }
}
