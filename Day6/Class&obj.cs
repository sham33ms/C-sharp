using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class FileColor
    {
        class Car
        {
            class  Car1
            {
                // Fields , Variables or Property
                public string Color;
                public string Description;
                //Method
                public virtual void startEngine()
                {
                    Console.WriteLine("ENGINE STARTED");
                }
                public void engineRunning()
                {
                    Console.WriteLine(" Engine Running");
                }
            }
            class Car2 : Car1
            {
                public override void startEngine()
                {
                    Console.WriteLine("Off the Engine");
                }
            }
            public static void Main(string[] args)
            {
                Car1 myCar1 = new Car1();
                Car1 myCar2 = new Car1();
                Car2 myCar3 = new Car2();
                myCar1.Color = "Red";
                myCar1.Description = "BMW";
                myCar2.Color = "Blue";
                myCar2.Description = "TESLA";
                myCar1.startEngine();
                myCar3.startEngine();
                myCar3.engineRunning();
                Console.WriteLine("I do have 2 cars and those are "+myCar1.Color +" and "+myCar2.Color);
                Console.WriteLine("The brand is "+myCar1.Description +" and "+myCar2.Description);
            }
        }            
    }
}
