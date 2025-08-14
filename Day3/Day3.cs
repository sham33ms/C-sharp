using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Day3
    {
        public static void Main(string[] args)
        {
            // Condition-------------------
            // if, else , elseif 

            int balance = 5;
            if (balance < 5)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Console.WriteLine("Transaction complete");
            }

            // short hand if uses terinary operator
            string result = (balance <= 49) ? "ok" : "no";
            Console.WriteLine(result);

            //switch
            int day = 3;
            ++day;
            switch (day)
            {
                case 0:
                    Console.WriteLine("today");
                    break;
                case 1:
                    Console.WriteLine("Tommorow");
                    break;
                case 2:
                    Console.WriteLine("Day afterr tommorow");
                    break;
                default:
                    Console.WriteLine("yesterday");
                    break;
            }


            // looping-------------------
            // for loop
            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    Console.WriteLine("Transaction complete");
                }
            }
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            // while 
            int while1 = 001;
            while (while1 < 5)
            {
                Console.WriteLine(while1);
                while1++;
            }
            //do while
            int while2 = 0;
            do
            {
                while2++;
                Console.Write(while2++);
            }
            while (while2 < 10);//output : 1 3 5 7 9


            //break & continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 8)
                {
                    break;
                }
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            //Mark and calculation------------ 
           int[] score = new int[5];
            Console.WriteLine("Enter 5 scores (0-100):");


            for (int i = 0; i < score.Length; i++)// for loop to store values in the array
            {

                int input = int.Parse(Console.ReadLine());// Get the input
                if (input >= 0 && input <= 100)// check if the Value is between 0-100
                {
                    score[i] = input; // store only if valid
                }
                else
                {
                    Console.WriteLine("Enter numbers between 0-100");
                    i--; // retry the same index
                }
            }

            Console.WriteLine("\nYou entered:");
            foreach (int sc in score)// to print the array
            {
                Console.Write(sc + " ");
            }

            int sum = 0;
            double avg = 0;
            for (int i = 0; i <= 4; i++)// calculating the avg of the data
            {
                sum += score[i];
                avg = sum / (double)score.Length;

            }
            Console.WriteLine("\nThe average mark is : " + avg);

            string pass = (avg >= 50) ? "Pass 50" : "Doesn't pass 50";// check the avg of the array is over the 50 or not 
            Console.WriteLine(pass);

            string sentence = "The performaance of the class is ";

            switch ((int)avg / 10)// switch casing and printing the performance of the class accordingly

            {
                case 10:
                case 9:
                    Console.WriteLine(sentence + "Excellent");
                    break;
                case 8:
                case 7:
                    Console.WriteLine(sentence + "Good");
                    break;
                case 6:
                case 5:
                    Console.WriteLine(sentence + "Average");
                    break;
                default:
                    Console.WriteLine(sentence + "Poor");
                    break;
            }
            foreach (int scre in score)// Traversing the aray 
            {
                while (scre > 80)// Fnding the scores greater than 80
                {
                    Console.WriteLine("The scores greater than 80 are : " + scre);
                    break;
                }
            }


        }
    }
}
