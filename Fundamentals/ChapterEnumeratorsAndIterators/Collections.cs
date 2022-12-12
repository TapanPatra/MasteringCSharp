using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class Collections
    {
        public static readonly int[] seeds = { 10, 20 };
        [Test]
        public void ArrayBasics()
        {
            int[] array = new int[5];
            array[0] = 10;
            int value = array[0];

            Assert.AreEqual(10, value);

            Assert.AreEqual(5, array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, array[i]);
            }

            foreach (int tmp in array)
            {
                Console.WriteLine(tmp);
            }

            IEnumerable<int> sequence = array;

            foreach (var tmp in array)
            {
                Console.WriteLine(tmp);
            }


        }

        [Test]
        public void ArrayMutability()
        {
            seeds[0] = 30;
            Console.WriteLine(seeds[0]);

        }

        [Test]
        public void ListBasic()
        {
            List<string> names = new List<string>();

            names.Add("fred");
            Assert.AreEqual("fred", names[0]);

            Assert.AreEqual(1, names.Count);
            names.Add("betty");
            Assert.AreEqual(2, names.Count);

            names.RemoveAt(0);
            Assert.AreEqual(1, names.Count);
            Assert.AreEqual("betty", names[0]);

            names[0] = "banny";
            Assert.AreEqual("banny", names[0]);

            var integers = new List<int>() { 10, 20 };
            Assert.AreEqual(2, integers.Count);
        }

        [Test]
        public void DictionaryBasaics()
        {
            var map = new Dictionary<string, int>();

            map.Add("foo", 10);
            map["bar"] = 20;

            foreach(var item in map)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            int value;

            bool keyFound = map.TryGetValue("bla", out value);
            Assert.IsFalse(keyFound);
            Assert.AreEqual(0, value);


            keyFound = map.TryGetValue("bar", out value);
            Assert.IsTrue(keyFound);
            Assert.AreEqual(20, value);

            Assert.AreEqual(2, map.Count);

            var map2 = new Dictionary<string, int>()
            {
                {"abc", 1 },
                {"xyz", 2 }
            };



        }

        [Test]
        public void Generics()
        {
            Fred<string> fred1 = new Fred<string>("ABC");
            Assert.AreEqual("ABC", fred1.Foo());


            Fred<int> fred2 = new Fred<int>(10);
            Assert.AreEqual(10, fred2.Foo());
           
        }

        [Test]
        public void VarKeyword()
        {
            var fred1 = new Fred<string>("ABC");
            Assert.AreEqual("ABC", fred1.Foo());


            var fred2 = new Fred<int>(10);
            Assert.AreEqual(10, fred2.Foo());

        }

        public class Fred<T>
        {
            readonly T greeting;

            public Fred(T greeting)
            {
                this.greeting = greeting;
            }

            public T Foo()
            {
                return greeting;
            }
           
        }

    }
}
