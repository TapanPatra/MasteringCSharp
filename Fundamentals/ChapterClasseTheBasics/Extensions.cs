using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class Extensions
    {
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static byte[] ReadFully(Stream input)
        {
            MemoryStream output = new MemoryStream();
            byte[] buffer = new byte[8192];
            int bytesread;

            while ((bytesread=input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesread);
            }

            return output.ToArray();
        }

        public static string EReverse(this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static byte[] EReadFully(this Stream input)
        {
            MemoryStream output = new MemoryStream();
            byte[] buffer = new byte[8192];
            int bytesread;

            while ((bytesread = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, bytesread);
            }

            return output.ToArray();
        }

        public static int DoubleLength(this string input)
        {
            return input.Length * 2;
        }
    }
}
