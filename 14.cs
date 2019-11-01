using System;
using System.Collections.Generic;
using System.Text;

namespace WEB1
{
    class _14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("по убыванию или по возрастанию сортировать?");
            string s = Console.ReadLine();
            Console.WriteLine("Введите массив");
            string str = Console.ReadLine();
            string[] tmp = str.Split(' ');
            int[] array = new int[tmp.Length];
            int temp = 0;
            for (int i = 0; i< tmp.Length; i++)
            {
                array[i] = int.Parse(tmp[i]);
            }
            if (s == "по возрастанию")
            {
                for (int i = tmp.Length; i > 0; i--)
                {
                    for (int j = 0; j < tmp.Length-1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            if (s == "по убыванию")
            {
                for (int i = tmp.Length; i > 0; i--)
                {
                    for (int j = 0; j < tmp.Length-1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }

        }
    }
}
