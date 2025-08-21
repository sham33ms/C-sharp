class Mainn
{
    static void Main(string[] args)
    {
        string oldpath = @"C:\Shameem123";
        string newpath = @"C:\Shameem";

        if (Directory.Exists(oldpath))
        {
            Directory.Move(oldpath, newpath);
            Console.WriteLine("Path Changed");
        }

        else
        {
            Console.WriteLine("Path not found");
        }
    }
}