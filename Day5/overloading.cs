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
            static int Add(int a, int b)          // Version 1
            {
                return a + b;
            }

            static double Add(double a, double b) // Version 2
            {
                return a + b;
            }

            static string Add(string a, string b)   // Version 3
            {
                return a + " " + b;
            }

            static void Main()
            {
                int choice = 0;
                Console.WriteLine("Choose the method of addiition" +
                                    "\nEnter 1 For Integers:" +
                                    "\nEnter 2 For Decimals:" +
                                    "\nEnter 3 For String: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter 2 Whole numbers for addition :");
                        int num1 = int.Parse(Console.ReadLine());
                        int num2 = int.Parse(Console.ReadLine());
                        int add1 = Add(num2, num1);
                        Console.WriteLine("The Addition of two integers:" + add1);
                        break;
                    case 2:
                        Console.WriteLine("Enter 2 Whole numbers for addition :");
                        double num3 = double.Parse(Console.ReadLine());
                        double num4 = double.Parse(Console.ReadLine());
                        double add2 = Add(num3, num4);
                        Console.WriteLine("The Addition of two integers:" + add2);
                        break;
                    case 3:
                        Console.WriteLine("Enter 2 Whole numbers for addition :");
                        string str1 = Console.ReadLine();
                        string str2 = Console.ReadLine();
                        string str = Add(str1, str2);
                        Console.WriteLine("The Addition of two strings:" + str);
                        break;
                    default:
                        Console.WriteLine("No methods like this");
                        break;

                }

            }
        }
    }
}
