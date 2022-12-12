using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
   public class ForEach
    {
        [Test]
        public void ArrayIteration()
        {
            int[] array = new int[] { 3, 5, 7 };
            DisplayContent(array);
        }

        [Test]
        public void ListIteration()
        {
            List<string> list = new List<string>() { "a", "b", "c" };
            DisplayContent(list);
        }

        private void DisplayContent<T> (IEnumerable<T> collection)
        {
            using (IEnumerator<T> iterator = collection.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                }

            }
        }
    }
}
