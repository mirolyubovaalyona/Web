using System;
using System.Collections.Generic;
using System.Text;

namespace WEB1
{
    class _16
    {
        static void Main16(string[] args)
        {
            Console.WriteLine("длинный текст?");
            string str = Console.ReadLine();
            string[] tmp = str.Split(' ');
            Console.WriteLine("Количество слов: {0}", tmp.Length);
            int l = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                l += tmp[i].Length;
            }
            Console.WriteLine("Количество символов без пробелов: {0}", l);
            float a = 0;
            a = l / tmp.Length;
            Console.WriteLine("Соотношение количество символов без пробелов к количеству слов: {0:f}", a);
            Console.Write("Слово из последних символов слов:");
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[i][tmp[i].Length-1]);
            }
        }
    }
}
