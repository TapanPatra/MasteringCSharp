using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class DerivedClassTest
    {
        [Test]
        public void DefaultName()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual("derived default", test.Name);
        }

        [Test]
        public void SpecifiedNamePropagated()
        {
            BaseClass test = new DerivedClass("Tapan");
            Assert.AreEqual("derived Tapan", test.Name);
        }

        [Test]
        public void TripleInput()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(15, test.TripleInput(5));
        }


        [Test]
        public void QuadarpleInput()
        {
            DerivedClass test = new DerivedClass();
            Assert.AreEqual(20, test.QuadarapleInput(5));
        }

        [Test]
        public void CalculateResult()
        {
            DerivedClass test = new DerivedClass();
            Assert.AreEqual(4, test.CalculateResult(8));
        }
    }
}
