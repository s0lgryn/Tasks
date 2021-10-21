using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int counter=0;
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next();
                if (x[i] < 10 & x[i] > -10)
                    counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
