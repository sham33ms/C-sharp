using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class FileName
    {
      
        class Program
        {
                // Method that returns both quotient and remainder using out
                static void Divide(int a, int b, out int quotient, out int remainder)
                {
                    quotient = a / b;   // must assign value before method ends
                    remainder = a % b;  // must assign value before method ends
                }

                static void Main()
                {
                    // Passing variables with 'out'
                    Divide(17, 5,out int  q, out int  r);

                    Console.WriteLine("Quotient = " + q);
                    Console.WriteLine("Remainder = " + r);
                }
        }

    }
}
