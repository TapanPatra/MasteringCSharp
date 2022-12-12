using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Fundamentals.Tests
{
    [TestFixture]
    public class ExtensionsTest
    {



        [Test]
        public void InvokeReverse()
        {
            string reversed = Extensions.Reverse("hello");
            Assert.AreEqual("olleh", reversed);

        }

        [Test]
        public void ReadFully()
        {
            var request = WebRequest.Create("http://www.google.com"); 
            using(var response = request.GetResponse())
            {
                using(var responsestream = response.GetResponseStream())
                {
                    byte[] data = Extensions.ReadFully(responsestream);
                    Console.WriteLine(data.Length);
                }
              
            }
        }

        [Test]
        public void InvokeReverseUsingExtension()
        {
            string reversed = "hello".EReverse();
            string reversed2 = Extensions.Reverse("hello");
            Assert.AreEqual("olleh", reversed);

        }

        [Test]
        public void ReadFullyUsingExtension()
        {
            var request = WebRequest.Create("http://www.google.com");
            using (var response = request.GetResponse())
            {
                using (var responsestream = response.GetResponseStream())
                {
                    byte[] data = responsestream.EReadFully();
                    Console.WriteLine(data.Length);
                }

            }
        }

        [Test]
        public void MiniLinq()
        {
            string[] names = { "Tapan", "Halikul", "Ammiraju", "Sapan", "Mani" };

            var query = names.Select(x => x.Length)
                             .Where(x => x > 5);

            foreach(var result in query)
            {
                Console.WriteLine(result);
            }


            var query2 = names.Where(x => x.EndsWith("n"))
                              .Select(x => x.ToUpper());

            foreach(var result in query2)
            {
                Console.WriteLine(result);
            }


            string[] mynames = { "Holly", "Rob", "Jon", "Tom", "William" };

            var query3 = names.Where(x => !x.EndsWith("m"))
                              .Select(x => new
                              {
                                  UpperName = x.ToUpper(),
                                  NameLength = x.Length
                              });

            foreach (var result in query3)
            {
                Console.WriteLine(result);
            }

            var filtered = MasteringEnumerable.Where(names, 
                                                        x => !x.EndsWith("m"));


            var query4 = MasteringEnumerable.Select(filtered,
                                                        x => new
                                                        {
                                                            UpperName = x.ToUpper(),
                                                            NameLength = x.Length
                                                        });
                                

            foreach (var result in query4)
            {
                Console.WriteLine(result);
            }


            var query5 = from x in mynames
                         where !x.EndsWith("m")
                         select new {UpperName = x.ToUpper(),NameLength = x.Length};

            foreach (var result in query5)
            {
                Console.WriteLine(result);
            }




        }
    }
}
