using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterStructs
{
    public struct Point
    {
        int m_x;
        int m_y;

        public Point(int x, int y)
        {
            m_x = x;
            m_y = y;
        }

        public override string ToString()
        {
            return String.Format("X is {0} and Y is {1}", m_x, m_y);
        }

    }
}
