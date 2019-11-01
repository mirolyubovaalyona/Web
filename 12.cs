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
            int a, b;
            string str = "";
            while (str != "exit")
            {
                str = Console.ReadLine();
                if (str == "+")
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("a + b = ");
                    Console.WriteLine( a + b);
                }
                else if (str == "-")
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("a - b = ");
                    Console.WriteLine(a - b);
                }
                else if (str == "*")
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("a * b = ");
                    Console.WriteLine(a * b);
                }
                else if (str == "/")
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("a / b = ");
                    Console.WriteLine(a / b);
                }
                else if (str != "exit")
                {
                    Console.WriteLine("'+' or '-' or '*' or '/' or 'exit'");
                    str = Console.ReadLine();
                }
            }
        }
    }
}
