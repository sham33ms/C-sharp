using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class class1
    {
        public int x;
        public int y;
        public class1(int abc, int y)
        {
            x = abc;
            this.y = y;

        }
        public void display()
        {
            int y = 10;
            Console.WriteLine(x + "+" + this.y+"+"+y);
        }
    }
    class class2
    {
        public static void Main(string[] args)
        {
            class1 neew = new class1(8,6);
            neew.display();
        }
    }
}