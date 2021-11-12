using System;
using System.Collections.Generic;

namespace O5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, s1, s2;
            Console.Write("Введите первое слово:");
            s1 = Console.ReadLine();
            Console.Write("Введите второе слово:");
            s2 = Console.ReadLine();
            s = s1 + s2;
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
                if (s.IndexOf(s[i]) == i && s.LastIndexOf(s[i]) == i)
                    Console.Write(s[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
