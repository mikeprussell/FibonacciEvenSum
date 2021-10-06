using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        /*
         * This program totals up only the even numbers within a
         * Fibonacci sequence up to $4 million (not to exceed $4m).
         */

        static void Main(string[] args)
        {
            //Three variables are used to generate the Fibonacci sequence
            int n1 = 0;
            int n2 = 1;
            int n3;

            //A variable to keep a running tally of even numbers in the sequence
            int fiboEvenSum = 0;

            for (int i = 1; i <= 99999999; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                Console.WriteLine($"{n3:n0} - {i}");

                if (n3 % 2 == 0 && (n3 <= 4000000))
                {
                    fiboEvenSum += n3;
                }
                else if (n3 > 99999999)
                {
                    i = n3;
                }

            }

            Console.WriteLine($"The sum of the even numbers in the Fibonacci sequence is {fiboEvenSum:n0}.");
        }
    }
}
