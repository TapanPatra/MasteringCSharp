using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class StartAndStopTest
    {
        [Test]
        public void StartAndStop()
        {
            Dancer tapDance = new TapDancer();
            ChainShawDancer chainSaw = new ChainShawDancer();

            StartAndStopper test = new StartAndStopper();
            test.StartAndStop(tapDance);
            test.StartAndStop(chainSaw);
        }
    }
}
