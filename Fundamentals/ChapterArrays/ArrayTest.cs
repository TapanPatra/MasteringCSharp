using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Fundamentals.Tests
{
    [TestFixture]
    public class ArrayTest
    {
        [Test]
        public void Print_Any_That_Appear_in_BothArray()
        {
            /*
            2 arrays. Print any that appear in both
            Example:
            a1 = {'c', 'a', 'b', 'c'}
            a2 = {'b', 'c', 'd'}
 
            Expected Result: {'b', 'c'}
            */
            char[] a = new char[] { 'a', 'a', 'a', 'a' };
            char[] b = new char[] { 'a', 'a', 'a' };
            PrintDups(a, b);

        }

        private void PrintDups(char[] a, char[] b)
        {
            Dictionary<char, int> aMap = new Dictionary<char, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!aMap.ContainsKey(a[i]))
                {
                    aMap.Add(a[i], 1);
                }
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (aMap.ContainsKey(b[i]))
                {
                    Console.WriteLine(b[i]);
                    if (aMap[b[i]] == 1)
                    {
                        aMap.Remove(b[i]);
                    }
                }

            }

        }
    }
}
