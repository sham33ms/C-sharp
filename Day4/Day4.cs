using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Day4
    {
        public static void Main(string[] args)
        {
            // 1D array
            int[] arr = { 1, 2, 3, 4, 5, };//1D array initializaton
            int[] arr2 = new int[4];

            Console.WriteLine(arr[0]);// accessing the elements useing index
            Console.WriteLine(arr[1]);

            arr2[2] = 3;// only 2nd inddex is set to value 3 others will be 0


            //Console.WriteLine(arr); Array cant be printed like this
            foreach (int i in arr) Console.Write(i + "  ");// printing a array by traversing
            Console.WriteLine();
            foreach (int i in arr2) Console.Write(i + "  ");// the size set to be 4 so no values will be shown as 0

            //2D array
            int[,] arr2d;// 2D array initialization '[,]'
            arr2d = new int[,] {
                { 1,2,3},
                { 4,5,6}
            };
            arr2d[0, 2] = 2;// accessing the 2d array using its index
            Console.WriteLine(arr2d[1, 2]);

            for (int i = 0; i < 2; i++) // need two loops to traverse and print the array for rows
            {
                for (int j = 0; j < 3; j++)// for coloumns 
                {
                    Console.Write(arr2d[i, j]); //print the coloum
                }
                Console.WriteLine();//go to next line for the next row
            }


            // Jagged array
            int[][] jarr = new int[4][];// initializing jagged array with size

            jarr[0] = new int[] { 1, 2 };//indexing 
            jarr[1] = new int[] { 3, 4, 5 };
            jarr[2] = new int[] { 6 };
            jarr[3] = new int[] { 7, 8, 9, 0 };

            foreach (int[] i in jarr)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            int[][] jarr1 = new int[][]// another way of intialization where size is not mentioned
            {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6 },
                new int[] { 7, 8, 9, 0 }
            };

            foreach (int[] row in jarr)
            {
                foreach (int val in row)
                    Console.Write(val + " ");
                Console.WriteLine();
            }

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            // Create jagged array for meals 
            string[][] weeklyMenu = new string[7][];
            // Initialize each day with different number of meals/snacks 
            weeklyMenu[0] = new string[] { "Pancakes", "Salad", "Grilled Chicken", "aerstdyufgioh", "zerxtdfyug" };
            weeklyMenu[1] = new string[] { "Oatmeal", "Veggie Wrap" };
            weeklyMenu[2] = new string[] { "Toast", "Soup", "Steak", "Ice Cream" };
            weeklyMenu[3] = new string[] { "Cereal", "Pizza" };
            weeklyMenu[4] = new string[] { "Egg Sandwich", "Biryani", "Gulab Jamun" };
            weeklyMenu[5] = new string[] { "Paratha", "Chole Bhature", "Samosa", "Lassi" };
            weeklyMenu[6] = new string[] { "Idli", "Dosa", "Vada" };
            // Display the weekly menu 
            Console.WriteLine("🍽 Weekly Menu Planner:");
            Console.WriteLine("-----------------------");

            for (int day = 0; day < weeklyMenu.Length; day++)
            {
                Console.WriteLine($"{days[day]}:");
                for (int meal = 0; meal < weeklyMenu[day].Length; meal++)
                {
                    Console.WriteLine($"   - {weeklyMenu[day][meal]}");
                }
                Console.WriteLine();
            }


            //String & its methods--------------------------------
            string name = "Hello World";

            Console.WriteLine(name.ToUpper()); // HELLO WORLD
            Console.WriteLine(name.ToLower()); // hello world
            Console.WriteLine(name.Contains("World")); // True
            Console.WriteLine(name.Replace("World", "C#")); // Hello C#
            Console.WriteLine(name.Substring(6, 3)); // Wor


            //String builder----------------------------------
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");
            sb.Insert(0, "Say: ");
            sb.Replace("World", "C#");
            Console.WriteLine(sb.ToString()); // Say: Hello C#


            //List <t>
            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.Add(4); // Add at end
            numbers.Insert(1, 10); // Insert at position 1
            numbers.Remove(3); // Remove value

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


            //Dictionary<TKey, TValue>

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["John"] = 25;
            ages["Alice"] = 30;

            Console.WriteLine(ages["John"]); // 25

            // Loop through key-value pairs
            foreach (var pair in ages)
            {
                Console.WriteLine(pair.Key + " is " + pair.Value);
            }

            //HashSet<T>

            HashSet<int> set = new HashSet<int>();// Initialization method for hasset
            set.Add(1);// adding elements
            set.Add(2);
            set.Add(2); // Duplicate, ignored


            HashSet<int> set1 = new HashSet<int>// another type of intialztion 
            {
                2,3,4
            };

            set.UnionWith(set1);// union of 2 sets
            set.IntersectWith(set1);//intersection of 2 sets
            foreach (int num in set)
            {
                Console.WriteLine(num);
            }
        }   
    }
}
