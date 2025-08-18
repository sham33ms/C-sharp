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
            // Method that doubles the number using ref
            static void DoubleNumber(ref int num)
            {
                num = num * 2;
            }

            static void Main()
            {
                int x = 10;
                Console.WriteLine("Before method call: " + x);

                // Passing by reference
                DoubleNumber(ref x);

                Console.WriteLine("After method call (doubled): " + x);
            }
        }
    }
}
