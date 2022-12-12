using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
namespace Fundamentals.Tests
{
    [TestFixture]
    public class SimpleTypes
    {
        [Test]
        public void DisplayValues()
        {
            /*
             * int = System.Int32
             * uint = System.UInt32
             * 
             * long = System.Int64
             * ulong = System.UInt64
             * 
             * byte = System.Byte (8 bits)
             * sbyte = System.SByte
             
            short = System.Int16
            ushort = System.UInt16 
            
            int x = 10;
            x++;
            x+= 10;
            
            int y = (x << 2) & 5 ;
             
             */


            /*
             *float = System.Single 16bit
             * double = System.Double 32 bit --- Binary 
             * decimal = System.Decimal 64bit 
             * float v1 = 0.2f;
               double v2 = 0.2d;
            /  decimal v3 = 0.2m;
             * 
             * sign bit
             * Mantisa
             * exponent
             * 
             * in Decimal 
             * 12345.25 ----- 
             *          1.234525 * 10^4 ------ 
             *                  sign 0 
             *                  Mantisa 1
             *                  exponent 4
             *                  
             *  3.25 in Decimal 
                11.01 in Binary 
                11.01× 2^0 = 11.01
                1.101 × 2^1 = = 11.01
                Sign: 0 (a positive number)
                Exponent (unadjusted): 1
                Mantissa (not normalized): 1.101
             */

            double v2 = 0.2d;
            decimal v4 = (decimal)v2;
            Console.WriteLine(v4);
            int sign = Math.Sign(5);
            Console.WriteLine(sign);

        }

    }
}
