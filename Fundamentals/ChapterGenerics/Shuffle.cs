using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ChapterGenericTypes
{
    public class Shuffler
    {
        public static List<T> Shuffle<T>(List<T>list1, List<T> list2)
        {
            List<T> shuffled = new List<T>();
            for(int i =0; i < list1.Count; i++)
            {
                shuffled.Add(list1[i]);
                shuffled.Add(list2[i]);

            }

            return shuffled;

        }
    }
}
