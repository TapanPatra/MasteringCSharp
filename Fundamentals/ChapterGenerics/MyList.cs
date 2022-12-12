using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterGenericTypes
{
    class MyList <T> : IMyList<T>
                       where T : new() //The compiler knows that a parameterless constructor will always be there for type T.
    {
        T[] m_values;
        int m_count = 0;

        public MyList(int capacity)
        {
            m_values = new T[capacity];
            for(int i=0; i<capacity; i++)
            {
                m_values[i] = new T();
            }
        }

        public void Add(T value)
        {
            m_values[m_count] = value;
            m_count++;
        }

        public T this[int index]
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
