using System.IO;
using System;

class Program
{
    static void Main()
    {
        // Writing to a file
        using (StreamWriter sw = new StreamWriter("test.txt"))
        {
            sw.WriteLine("Hello, World!");
            sw.WriteLine("This is a text file.");
        }

        // Reading from a file
        using (StreamReader sr = new StreamReader("test.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
