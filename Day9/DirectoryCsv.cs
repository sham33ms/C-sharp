//using iTextSharp.text.pdf;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\MyFolder";
        string path1 = Path.Combine(path, "data.csv");


        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Folder created!");

            // Write CSV
            File.WriteAllText(path1, "Name,Age\nShameem,20\nRahul,22\nRishi,22");

            // Read CSV
            string[] lines = File.ReadAllLines(path1);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Directory.Delete(path, true);
            Console.WriteLine("Folder already exists.");
        }
    }
}
