using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterInterfaces
{
    public class Base : IHelper
    {
         void IHelper.HelpMeNow()
        {
            Console.WriteLine("Base.HelpMeNow");
        }
    }
}
