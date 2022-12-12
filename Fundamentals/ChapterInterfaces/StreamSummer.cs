using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
   public class StreamSummer
    {

        public int Sum(Stream stream)
        {

            int value;
            int result = 0;

            while( (value=stream.ReadByte()) != -1)
            {
                result += value;
            }

            return result;
        }
    }
}
