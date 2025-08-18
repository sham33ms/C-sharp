using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class FileName
    {
        class claculator
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
            public static int Sub(int a, int b)
            {
                return a - b;
            }
            static void Main(string[] args)
            {
                string choice;
                Console.WriteLine("Enter any 2 choice Add or Sub : ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "Add":
                        Console.WriteLine("Enter 2 Whole numbers for addition :");
                        int c = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());
                        int result = Add(c, d);
                        Console.WriteLine("The addition of " + c + " and " + d + " is :" + result);
                        break;

                    case "Sub":

                        Console.WriteLine("Enter 2 Whole numbers for substraction :");
                        int s = int.Parse(Console.ReadLine());
                        int r = int.Parse(Console.ReadLine());
                        int result1 = Sub(s, r);
                        Console.WriteLine("The substraction of " + s + " and " + r + " is :" + result1);
                        break;
                    default:
                        Console.WriteLine("No other operation cant be done");
                        break;
                }
            }

            }
        }
    }
