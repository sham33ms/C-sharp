public interface Ihandle
{
    void test();

    void method();
}
public interface Ihandle1
{
    void method();

    void method1();
}
public class Class1 : Ihandle, Ihandle1
{
    public void test()
    {
        Console.WriteLine("Test");
    }
    public void method()
    {
        Console.WriteLine("Method");
    }
    public void method1()
    {
        Console.WriteLine("Method");
    }
}

public class Mainn
{
    public static void Main(string[] args)
    {
        Class1 obj = new Class1();
        obj.test();
        obj.method();
    }
}