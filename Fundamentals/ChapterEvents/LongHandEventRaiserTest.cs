using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Fundamentals.Tests
{
    public class LongHandEventRaiserTest
    {
        private void ReportToConsole(object sender, EventArgs e)
        {
            Console.WriteLine("Report console is Called");
        }

        [Test]
        public void RaiseEvents()
        {

            ClickHandler handler = ReportToConsole;

            var raiser = new LongHandEventRaiser();
            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click += handler;
            raiser.OnClick();

            raiser.Click -= handler;
            raiser.Click -= handler;
            raiser.OnClick();


        }
    }
}
