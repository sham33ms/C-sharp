class Mainn
{
    static void Main(string[] args)
    {
        string path = @"C:\Shameem";
        if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
            Console.WriteLine("Deleted successfully");
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}