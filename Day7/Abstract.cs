using System;

public abstract class Class1
{
    public abstract void Abccls();

    public void method()
    {
        Console.WriteLine("Abstract");
    }
}

public class Class2 : Class1
{
    public override void Abccls()
    {
        Console.WriteLine("Child");
    }

}
public class Mainn
{
    public static void Main(string[] args)
    {
        Class1 obj1 = new Class2();
        obj1.Abccls();

        Class2 obj2 = new Class2();
        obj2.Abccls();
        obj2.method();
    }
}