using System;
using System.Collections.Generic;
using System.Text;

namespace WEB1
{
    class _15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) =((-b+-((b)^2-4ac))^(1/2))/(2a)");
            Console.WriteLine("2) =(xy)/((x^2)+(y^2)+5)^(1/2)");
            Console.WriteLine("3) =((x^2)+(y^2)+2x)/(x^2)+(y^2)-2x))^(1/2)");
            Console.WriteLine("4) =((1/a)^a)+((1/b)^b)+((1/c)^c)");
            string ch = Console.ReadLine();
            string s = Console.ReadLine();
            string[] tmp = s.Split(' ');
            int a, b, c;
            if (ch == "1")
            {
                a = int.Parse(tmp[0]);
                c = int.Parse(tmp[2]);
                b = int.Parse(tmp[1]); 
                Console.Write("x1 = ");
                Console.WriteLine(((-b -((b ^ 2) - 4 * a * c)) ^ (1 / 2)) / (2 * a));
                Console.Write("x2 = ");
                Console.WriteLine(((-b + ((b ^ 2) - 4 * a * c)) ^ (1 / 2)) / (2 * a));
            }
            else if (ch == "2")
            {
                a = int.Parse(tmp[0]);
                b = int.Parse(tmp[1]);
                Console.Write("f(x, y) = ");
                Console.WriteLine((a*b) / ((a * a) + (b*b) + 5) ^ (1 / 2));
            }
            else if (ch == "3")
            {
                a = int.Parse(tmp[0]);
                b = int.Parse(tmp[1]);
                Console.Write("f(x, y) = ");
                Console.WriteLine((((a ^ 2) + (b ^ 2) + 2*a) / ((a ^ 2) + (b ^ 2) - 2*a))^(1 / 2));
            }
            else if (ch == "4")
            {
                a = int.Parse(tmp[0]);
                c = int.Parse(tmp[2]);
                b = int.Parse(tmp[1]);
                Console.Write("f(x, y) = ");
                Console.WriteLine(((1 / a) ^ a) + ((1 / b) ^ b) + ((1 / c) ^ c));
            }
            else {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
