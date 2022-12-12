using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Fundamentals.Tests
{
    public class FakeEventRaiserTest
    {
        private void ReportToConsole(string text)
        {
            Console.WriteLine("Called: {0}", text);
        }

        [Test]
        public void RaiseEvents()
        {
            FakeEventRaiserTest instance = new FakeEventRaiserTest();

            FakeEventHandler handler = new FakeEventHandler(instance.ReportToConsole);

            FakeEventRaiser raiser = new FakeEventRaiser();
            raiser.DoSomething("Not Subscribed");

            raiser.AddHandler(handler);
            raiser.DoSomething("Subscribed");

            raiser.AddHandler(handler);
            raiser.DoSomething("Subscribed twice");

            raiser.RemoveHandler(handler);
            raiser.RemoveHandler(handler);
            raiser.DoSomething("UnSubscribed");


        }
    }
}
