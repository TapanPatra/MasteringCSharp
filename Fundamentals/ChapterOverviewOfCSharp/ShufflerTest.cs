using Fundamentals.ChapterGenericTypes;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Fundamentals.Tests.ChapterGenericTypesTest
{

    [TestFixture]
    public class ShufflerTest
    {
        [Test]
        public void ShouldShuffleString()
        {
            List<string> list1 = new List<string>();
            list1.Add("One");
            list1.Add("Two");

            List<string> list2 = new List<string>();
            list2.Add("AAA");
            list2.Add("BBB");
            list2.Add("CCC");

            List<string> shuffled = Shuffler.Shuffle<string>(list1, list2);
            Console.WriteLine(shuffled.Count);
        }
    }
}
