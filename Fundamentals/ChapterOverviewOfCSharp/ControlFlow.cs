using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class ControlFlow
    {

        [Test]
        public void IfElse()
        {

	        int i = 10, j = 20;
	
	        if (i > j)
	        {
	            Console.WriteLine("i is greater than j");
	        }
	
	        if (i < j)
	        {
	             Console.WriteLine("i is less than j");
	        }        
	
	        if (i == j)
	        {
	            Console.WriteLine("i is equal to j");
	        }   

        }

        [Test]
        public void ElseIf()
        {
	         int i = 10, j = 20;

             if (i > j)
    	     {
        	    Console.WriteLine("i is greater than j");
   	 	     }
             else if (i < j)
    	     {
                Console.WriteLine("i is less than j");
    	     }
             else
    	     {
                Console.WriteLine("i is equal to j");
    	     }
        }

        [Test]
        public void Switch()
        {
	        int x = 10;

	        switch (x)
	        { 
	            case 5:
	            Console.WriteLine("Value of x is 5");
	            break;
	            case 10:
	            Console.WriteLine("Value of x is 10");
	            break;
	            case 15:
	            Console.WriteLine("Value of x is 15");
	            break;
	            default:
	            Console.WriteLine("Unknown value");
	            break;
	        }
        }

        [Test]
        public void ForLoop()
        {
	        for (int i = 0; i < 10; i++)
	        {
    	        Console.WriteLine("Value of i: {0}", i);
	        }
        }

        [Test]
        public void BreakInFor()
        {
	        for (int i = 0; i < 10; i++)
	        {
	            if( i == 5 )
	                break;
	
	            Console.WriteLine("Value of i: {0}", i);
	        }
        }

        [Test]
        public void While()
        {
	        int i = 0;
	
	        while (i < 10)
	        {
	            Console.WriteLine("Value of i: {0}", i);
	
	            i++;
	        }
        }

        [Test]
        public void BreakInWhile()
        {
	        int i = 0;
	
	        while (true)
	        {
	            Console.WriteLine("Value of i: {0}", i);
	
	            i++;
	
	            if (i > 10)
	                break;
	        }
        }

        [Test]
        public void DoWhile()
        {
	        int i = 0;
	
	        do
	        {
	            Console.WriteLine("Value of i: {0}", i);
	    
	            i++;
	
	        } while (i < 10);

        }
        [Test]
        public void Return()
        {
            Assert.AreEqual(12, MethodReturnInt32());
        }

        public int MethodReturnInt32()
        {
            return 12;
        }



        [Test]
        public void ContinueInWhile()
        {
            int x = 5;

            while(x < 10)
            {
                if(x%7 != 0)
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

        }

        [Test]
        public void NestedForLoop()
        {
            for(int i=0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    if( i+ j == 4)
                    {
                        break;
                    }

                    Console.WriteLine("i : {0} and j :{1}", i, j);
                }
            }

        }

        [Test]
        public void ForEach()
        {
            List<string> names = new List<string>() { "Tapan", "Halikul", "Ammiraju" };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

        }

    }
}
