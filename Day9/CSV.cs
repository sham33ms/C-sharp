using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "data.csv";

        // Write CSV
        File.WriteAllText(path, "Name,Age\nShameem,20\nRahul,22\nRishi,22");

        // Read CSV
        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
