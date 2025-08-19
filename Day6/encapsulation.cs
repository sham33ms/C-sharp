using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   public class class1
    {
        public int t;
        private int x;

        public int X 
        {
            get
            {
                return x;
            }
            set 
            {
                if (value > 2)
                {
                    x = value;
                }
                else
                {
                    x = 3;
                }
            } 
        }
        public void display()
        {
            Console.WriteLine(x);
        }
    }
    public class class2
    {
        public static void Main()
        {
            class1 obj = new class1();
            obj.t = 1;
            //Console.WriteLine(obj.t);
            obj.X = 7;
            obj.display();
            //Console.WriteLine(obj.X);

        }
    }
}
