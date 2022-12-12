using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public abstract class Dancer :IControllable
    {
        private readonly string name;

        protected Dancer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public abstract void Dance();

        public void DanceTwice()
        {
            Dance();
            Dance();
        }

        public void Start()
        {
            Console.WriteLine("Staring Dance");
            Dance();
        }

        public abstract void Stop();
        
        
    }
}
