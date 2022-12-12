using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Greeter
    {
        private readonly string speaker;

        public Greeter(string speaker)
        {
            this.speaker = speaker;

        }

        public string Speaker
        {
            get
            {
                Console.WriteLine("Returing Speaker is = " + speaker);
                return speaker;
            }
        }


        public string SayHello(string recipient)
        {
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient");
            }
            if(Speaker == null)
            {
                return "Hello " + recipient;
            }
            return "Hello " + recipient + " from " + speaker;
        }
    }
}
