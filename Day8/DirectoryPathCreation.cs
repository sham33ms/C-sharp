class Mainn
{
    static void Main(string[] args)
    {
        string path = @"C:\Shameem";
        if (Directory.Exists(path)) 
            Console.WriteLine("Already exist");
        else
        {
            Directory.CreateDirectory(path);
            Console.WriteLine("Created successfully");
        }
    }
}