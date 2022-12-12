using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterGenericTypes
{
    public class MyFirstList<T> : List<T>, IFirstItem<T>
    {
        public MyFirstList()
        {

        }
        T IFirstItem<T>.GetFirstItem()
        {
            return this[0];
        }
    }
}
