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

            for (int i = 1; i <= 4000000; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                if (n3 % 2 == 0 && (n3 <= 4000000))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{n3:n0} - {i}");
                    fiboEvenSum += n3;
                    Console.ResetColor();
                }
                else if (n3 > 4000000)
                {
                    i = n3;
                }
                else
                {
                    Console.WriteLine($"{n3:n0} - {i}");
                }

            }

            Console.WriteLine($"\nThe sum of the even numbers in the Fibonacci sequence is:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{fiboEvenSum:n0}.\n");
            Console.ResetColor();

        }
    }
}
