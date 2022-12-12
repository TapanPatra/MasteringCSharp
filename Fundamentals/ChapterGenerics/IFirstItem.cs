using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterGenericTypes
{
    public interface IFirstItem<out T>
    {
        T GetFirstItem();

       // void NotLegal(T parameter);
    }
}
