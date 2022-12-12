using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterGenericTypes
{
    public class IntList
    {
        int[] m_values;
        int m_count=0;

        public IntList(int capacity)
        {
            m_values = new int[capacity];
        }

        public void Add(int item)
        {
            m_values[m_count] = item;
            m_count++;
        }

        public int this[int index]
        {
            get
            {
                return m_values[index];
            }
            set
            {
                m_values[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return m_count;
            }
        }
    }

}
