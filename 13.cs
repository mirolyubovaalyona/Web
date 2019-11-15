using System;
using System.Collections.Generic;
using System.Text;

namespace WEB1
{
    class _13 {
        static void Main13(string[] args) {
            int l, max, min;
            string s = Console.ReadLine();
            string[] tmp = s.Split(' ');
            l = int.Parse(tmp[0]);
            max = int.Parse(tmp[2]);
            min = int.Parse(tmp[1]);
            int[] a = new int[l];
            Random rand = new Random();
            for (int i = 0; i < l; i++)
            {
                a[i] = rand.Next(min, max+1);
                Console.Write(a[i] + " ");
            }
        }
    }
}
