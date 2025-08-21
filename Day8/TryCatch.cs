class Mainn
{
    static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int div = a / b;
            Console.WriteLine(div);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: "+e.Message);
        }
        finally
        {
            Console.WriteLine("'Try Catch' completed");
        }
        
    }
}