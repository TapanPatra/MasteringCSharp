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
    public class NumberTest
    {
        [Test]
        public void CompareNumber()
        {
            Number number1 = new Number(30);
            Number number2 = new Number(40);

            IComparable ic = (IComparable)number1;

            Console.WriteLine("number1 compared to number2 = {0}", ic.CompareTo(number2));


        }
    }
}
