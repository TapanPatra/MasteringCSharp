using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fundamentals.ChapterInterfaces;

namespace Fundamentals.Tests.ChapterInterfacesTest
{
    [TestFixture]
    public class DerivedTest
    {
        [Test]
        public void InterfaceInheritance()
        {
            Derived der = new Derived();
            der.HelpMeNow();

            IHelper helper = (IHelper)der;
            helper.HelpMeNow();

        }
    }
}
