using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class FileName
    {
        class Fact
        {
            static int Factorial(int a)
            {
                int result = 1;

                for (int i = 1; i <= a; i++)
                {
                    result *= i;
                }  
                return result;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number");
                int b = int.Parse(Console.ReadLine());
                int fact = Factorial(b);
                Console.WriteLine("Factorial of "+b+" is : " + fact);
            }
        }
    }
}
