using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Fundamentals.Tests
{

    [TestFixture]
    public class LinqTest
    {

        [Test]
        public void ReviewOfFeaturesUsedInLINQ()
        {
            //Annonymous Method and Type inference
            var person = new { FirstName = "Tapan", Age = 30 };
            Console.WriteLine(person);
            //Lambda Expression
            Func<string, bool> isLong = x => x.Length > 5;
            Console.WriteLine(isLong("TAPANPATRA"));

            //Extension Method
            int doubleLength = "foo".DoubleLength();
            Console.WriteLine(doubleLength);

        }

        [Test]
        public void OverviewOfLinq()
        {
            List<string> names = new List<string>
            {
                "Maninee, Family",
                "Tanmay, Family",
                "This is not valid",
                "Halikul, Collegue",
                "Uma, Friend"
            };

            Regex pattern = new Regex("([^,]*), (.*)");

            var query = from line in names
                        let match = pattern.Match(line)
                        where match.Success
                        select new
                        {
                            Name = match.Groups[1].Value,
                            RelationShip = match.Groups[2].Value
                        };

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }

        }

        [Test]
        public void OverviewOfLinqGroupBy()
        {
            List<string> names = new List<string>
            {
                "Maninee, Family",
                "Tanmay, Family",
                "This is not valid",
                "Halikul, Collegue",
                "Uma, Friend"
            };

            Regex pattern = new Regex("([^,]*), (.*)");

            var query = from line in names
                        let match = pattern.Match(line)
                        where match.Success
                        select new
                        {
                            Name = match.Groups[1].Value,
                            RelationShip = match.Groups[2].Value
                        } into association
                        group association.Name by association.RelationShip;


            foreach (var grp in query)
            {
                Console.WriteLine("Relationship: {0}", grp.Key);
                foreach(var name in grp)
                {
                    Console.WriteLine("{0}", name);
                }
            }

        }

        [Test]
        public void CompilerVersionOfLinq()
        {
            List<string> names = new List<string>
            {
                "Maninee, Family",
                "Tanmay, Family",
                "This is not valid",
                "Halikul, Collegue",
                "Uma, Friend"
            };

            Regex pattern = new Regex("([^,]*), (.*)");

            var query = names.Select(line => new { line, match = pattern.Match(line) })
                             .Where(z => z.match.Success)
                             .Select(z => new
                             {
                                 Name = z.match.Groups[1].Value,
                                 RelationShip = z.match.Groups[2].Value
                             })
                             .GroupBy(association => association.RelationShip,
                                      association => association.Name);


            foreach (var grp in query)
            {
                Console.WriteLine("Relationship: {0}", grp.Key);
                foreach (var name in grp)
                {
                    Console.WriteLine("{0}", name);
                }
            }

        }

        [Test]
        public void UseOtherExpressionPatternInCodeNotLinq()
        {
            List<string> names = new List<string>
            {
                "Maninee, Family",
                "Tanmay, Family",
                "This is not valid",
                "Halikul, Collegue",
                "Uma, Friend"
            };

            Regex pattern = new Regex("([^,]*), (.*)");

            var queryLinq = from line in names
                            where line.Length < 15
                            select line;

            var queryExpressionPattern = names.Where(line => line.Length < 15);
        }

        [Test]
        public void OtherOperationsNotInQueryExpressions()
        {
            List<string> names = new List<string>
            {
                "Maninee, Family",
                "Tanmay, Family",
                "This is not valid",
                "Halikul, Collegue",
                "Uma, Friend"
            };

            var max = names.Max(name => name.Length);
            Console.WriteLine(max);
        }

    }


}
