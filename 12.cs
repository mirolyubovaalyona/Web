using System;
using System.Collections.Generic;
using System.Text;

/*При старте приложения, в консоле юзера просят выбрать одну из операций(+ - * /).
Потом два числа.
Потом вывести результат операции.
И повторно запросить выбор операции или предложить ввести exit для выхода.
Также нужно добавить обработку ошибок.*/


namespace WEB1
{
    class _12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'+' or '-' or '*' or '/' or 'exit'");
            float a, b;
            float c;
            string str = "";
            while (str != "exit")
            {
                str = Console.ReadLine();
                if (str == "+")
                {
                    a = float.Parse(Console.ReadLine());
                    b = float.Parse(Console.ReadLine());
                    Console.Write("a + b = ");
                    Console.WriteLine( a + b);
                }
                else if (str == "-")
                {
                    a = float.Parse(Console.ReadLine());
                    b = float.Parse(Console.ReadLine());
                    Console.Write("a - b = ");
                    Console.WriteLine(a - b);
                }
                else if (str == "*")
                {
                    a = float.Parse(Console.ReadLine());
                    b = float.Parse(Console.ReadLine());
                    Console.Write("a * b = ");
                    Console.WriteLine(a * b);
                }
                else if (str == "/")
                {
                    a = float.Parse(Console.ReadLine());
                    b = float.Parse(Console.ReadLine());
                    if ( b!= 0)
                    {
                        Console.Write("a / b = ");
                        c = a / b;
                        Console.WriteLine("{0:f}", c);
                    } else
                    {
                        Console.WriteLine("b != 0");
                        Console.WriteLine("'+' or '-' or '*' or '/' or 'exit'");
                    }
                }
                else if (str != "exit")
                {
                    Console.WriteLine("'+' or '-' or '*' or '/' or 'exit'");
                }
            }
        }
    }
}
