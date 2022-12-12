using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class ShortHandEventRaiser
    {
        public void OnClick()
        {
            ClickHandler tmp = Click;

            if(tmp != null)
            {
                tmp.Invoke(this, EventArgs.Empty);
            }

        }
        public event ClickHandler Click;       
       
    }
}
