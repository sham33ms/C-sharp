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
            static void Main()
            {
                int sum = 0;
                string input;

                Console.WriteLine("Simple Addition Calculator");
                Console.WriteLine("Type numbers to add. Type 'exit' to finish.\n");

                while (true)
                {
                    Console.Write("Enter a number (or 'exit'): ");
                    input = Console.ReadLine();

                    // Check if user wants to exit
                    if (input.ToLower() == "exit")
                        break;

                    // Try to convert input to number
                    if (int.TryParse(input, out int number))
                    {
                        sum += number;
                        Console.WriteLine("Current Sum = " + sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a number or 'exit'.");
                    }
                }

                Console.WriteLine("\nFinal Sum = " + sum);
                Console.WriteLine("Calculator ended.");
            }
        }
    }
}
