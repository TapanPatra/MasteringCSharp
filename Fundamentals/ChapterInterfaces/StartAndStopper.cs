using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class StartAndStopper
    {

        public void StartAndStop(IControllable controllable)
        {
            controllable.Start();
            controllable.Stop();
        }
    }
}
