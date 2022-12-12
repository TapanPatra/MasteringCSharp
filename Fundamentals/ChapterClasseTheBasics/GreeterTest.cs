using System;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class GreeterTest
    {
        [Test]
        public void SayHello_ReturnsHelloWithRecipientName()
        {
            Greeter greeter = new Greeter("Rob");
            string greeting = greeter.SayHello("Jon");
            Assert.AreEqual("Hello Jon from Rob", greeting);
        }

        [Test]
        public void CanConstructGreeterWithoutSpeakerName()
        {
            new Greeter(null);
        }

        [Test]
        public void SayHello_ReturnsHelloWithoutRecipientName()
        {
            Greeter greeter = new Greeter(null);
            string greeting = greeter.SayHello("Jon");
            Assert.AreEqual("Hello Jon", greeting);
        }
        [Test]
        public void SayHello_ReturnsArgumentNullException()
        {
            Greeter greeter = new Greeter("Rob");
            Assert.Throws<ArgumentNullException>(() => greeter.SayHello(null));
        
        }

        [Test]
        public void SpeakerProperty_IsSetFromConstructor()
        {
            Greeter greeter = new Greeter("Rob");
            Assert.AreEqual("Rob", greeter.Speaker);
            Assert.AreNotEqual("rob", greeter.Speaker);
        }
         
    }
}
