using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Datatypes
    {
        public static void Main(string[] args)
        {
            class1 obj1 = new class1();// creating an object
            obj1.datatype();//accsing the fn with object
            obj1.typecasting();
            obj1.operators();
            obj1.userinput();
            Console.WriteLine(obj1.fd);


        }

        public class class1
        {
            public int fd = 5;

            public void datatype()
            {
                string firstName = "Mohamed ";// string dt
                string secondName = "Shameem";
                int age1 = 10;// integer dt 
                int age2 = 10;
                char initial = 'S';// char dt 
                float mark10 = 70.25f;// float dt 
                decimal mark12 = 69.69m;// decimal dt 
                double avgmark = 70.00;// double dt 
                Boolean mark13 = true;//bool dt 
                Console.WriteLine(firstName + secondName + age1);// concatenation for string
                Console.WriteLine(age1 + firstName + age2 + secondName);
                Console.WriteLine(age1 + initial);// takes char  ascii value 
                Console.WriteLine(age1 + secondName + initial);
                Console.WriteLine(initial);
                Console.WriteLine(age1 + mark10);// works as a add operator when 2 num are given
                //Console.WriteLine(age1 + mark13); boolean cant be concatenated to num 
                Console.WriteLine(firstName + mark13);// concatenation with boolean  and string
            }
            public void typecasting()
            {
                // implicit casting char -> int-> long -> float-> double. Small to Large bit size
                char char1 = 'A';
                int age = char1;
                long age1 = age;
                float age2 = age1;
                double age3 = age2;
                Console.WriteLine(age3);

                //explicit casting double -> float -> long-> int -> char . Large to small bit size
                double age4 = 65.00;
                float age5 = (float)age4;
                long age6 = (long)age5;
                int age7 = (int)age6;
                char char2 = (char)age7;
                Console.WriteLine(char2);
            }
            public void operators()
            {
                //airthmetic
                int add = 100 + 56;// sum or add
                int add1 = 44 + add;
                int sub = add1 - 100;// substraction
                int mul = sub * 3;// multiplication
                int div = mul / 30;// division 
                int mod = div % 3;// modulus
                int x = 1;
                int postinc = x++;// post increment
                int postdec = x--;// post decrement 
                int preinc = ++x;//pre increment 
                int predec = --x;// pre decrement
                Console.WriteLine(div);
                Console.WriteLine(mod);
                Console.WriteLine(predec == x);

                // assignment
                int a = 10;// assigning a is 10
                int b = a += 10; // b=a=a+10
                a += 1;//a=a+1
                a -= 1;//a=a-1
                a *= 2;//a=a*2
                a /= 2;//a=a/2
                a %= 10;//a=a%10
                Console.WriteLine(b);
                Console.WriteLine(a);

                // comparision
                int y = 10;
                int z = 10;
                Console.WriteLine(y == z);// comparing if z is equal to y
                Console.WriteLine(z != y);// comparing if z not equal to y 
                Console.WriteLine(z < y);// comparing if z less than y
                Console.WriteLine(z > y);// comparing if z greater than y
                Console.WriteLine(y <= z);// comparing if y is lesser than or equal to z
                Console.WriteLine(y >= z);//comparing if y is greater than or equal to z

                // logical
                Boolean bol = y > 5 && y < 5;// check if the both condition are satisfied 
                Boolean bol2 = y > z && y < z;
                Boolean bol3 = y >= z || y < z;//check if one of the condition is satisfied 
                Boolean bol4 = !(bol2);// make the opposite 

                Console.WriteLine(bol);
                Console.WriteLine(bol2);
                Console.WriteLine(bol3);
                Console.WriteLine(bol4);
            }
            public void userinput()
            {
                Console.WriteLine("enter ur name "); 
                string name = Console.ReadLine();// getting a string 
                Console.WriteLine( "name is : " +name);

                Console.WriteLine("enter ur age ");
                int age = int.Parse(Console.ReadLine());// converting into a int becuse readline() only accept string
                Console.WriteLine("name is : " + age);

                Console.WriteLine("enter a number");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("enter a number");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine( "the addition is  : " +(a + b));

                Console.WriteLine("enter the base of a triangle");
                float d = float.Parse(Console.ReadLine());
                Console.WriteLine("enter the hieght of a  triangle");
                float f = float.Parse(Console.ReadLine());
                Console.WriteLine(" the area is : " + (0.5 * d * f));// finding area of a triangle


            }
        }

     
    }
}
