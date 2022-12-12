using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterInterfaces
{
    public struct Number:IComparable
    {
        int m_value;

        public Number(int value)
        {
            m_value = value;
        }

        public int CompareTo(object obj)
        {
            Number number2 = (Number)obj;

            if (m_value < number2.m_value)
            {
                return (-1);
            }
            else if (m_value > number2.m_value)
            {
                return (1);
            }

            else
            {
                return (0);
            }

        }
    }
}
