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

public abstract class abstract1
{
    public abstract void method();
    public abstract void method1();

    public void method2()
    {
        Console.WriteLine("Method 2");
    }
}
public class Class1 : abstract1 , Ihandle, Ihandle1 
{
    public void test()
    {
        Console.WriteLine("Test");
    }
    public override void method()
    {
        Console.WriteLine("Method");
    }
    void Ihandle.method()
    {
        Console.WriteLine("Interface");
    }
    public override void method1()
    {
        Console.WriteLine("Method 1");
    }
}

public class Mainn
{
    public static void Main(string[] args)
    {
        Class1 obj = new Class1();
        obj.test();
        obj.method();
        obj.method1();

        Ihandle ihandle = obj;
        ihandle.method();



    }
}