using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fundamentals.ChapterInterfaces;

namespace Fundamentals.Tests.ChapterGenericTypesTest
{
    [TestFixture]
    public class TesterTest
    {
        [Test]
        public void Test()
        {
            Tester tester = new Tester();

            tester.Execute();
            ((IFoo)tester).Execute();
            ((IBar)tester).Execute();

        }
    }
}
