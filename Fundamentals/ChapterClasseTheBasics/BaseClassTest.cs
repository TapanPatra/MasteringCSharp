using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
   public class BaseClassTest
    {
        [Test]
        public void CalculateDoubleInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(16, test.CalculateResult(8));
        }

        [Test]
        public void CalculateTripleInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(24, test.TripleInput(8));
        }

        [Test]
        public void NameDefaultToDefault()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual("default", test.Name);
        }

        [Test]
        public void SpecifiedNameIsPrpagated()
        {
            BaseClass test = new BaseClass("Tapan");
            Assert.AreEqual("Tapan", test.Name);
        }


    }
}
