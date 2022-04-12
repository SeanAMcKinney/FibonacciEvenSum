using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int EvenSum = 0;
                int x = 0; 
                int y = 1;
                int z = 0;           
            for (int i = 0; i < 4000000; i++)
            {
                z = x + y;               
                x = y;
                y = z;
                if (i % 2 == 0)
                {
                    EvenSum += i;
                }

            }
                Console.WriteLine(EvenSum);
               
        }//end main
    }//end class
}//end namespace
