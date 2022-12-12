using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterInterfaces
{
    public class TextObject : DiagramObject, IScalable
    {
        private string m_text;

        public TextObject(string text)
        {
            m_text = text;
        }
        void IScalable.ScaleX(float factor)
        {
            Console.WriteLine("Scaling Text" + m_text + " by " + factor.ToString() + "X Direction");
        }

        void IScalable.ScaleY(float factor)
        {
            Console.WriteLine("Scaling Text" + m_text + " by " + factor.ToString() + "Y Direction");
        }
    }
}
