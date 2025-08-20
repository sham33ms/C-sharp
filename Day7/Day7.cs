using System;

namespace shameem;

public  class class1 // Parent or Base class 
{
    public virtual void method()//virtual key word mentioned to overcome the refence object issue
    {
        Console.WriteLine("Shameem");
    }
    public virtual void method2()
    { Console.WriteLine("Shameem Shameem"); }
}
public class class2 : class1// Child or Derived class 
{
    public override void  method()// override key word mentioned so we can access through refrence object
    {
        Console.WriteLine("New class");
    }
}
public  class class3 : class1
{
    public void method()// override key word not specified , cant access through refrence object
    {
        Console.WriteLine("New class class");
    }
    public void method3()
    {
        Console.WriteLine("New Class3");
    }
}
public class Mainn
{
    public static void Main(string[] args)
    {
        class1 obj = new class1();
        obj.method();
        
        class1 obj1 = new class2();
        obj1.method();

        class1 obj2 = new class3();// Didnt use the override key word so it shows the parent class ouput.
        obj2.method();
        obj2.method2();
        //obj2.method3();Cannot do this because this a object for class1


        class3 obj3 = new class3 ();// Object created using the class not by refrence object
        obj3.method();
        obj3.method2();// can access the parent class method without refrence object
    }
}

