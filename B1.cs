using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            double y;
            if (x > 0)
                y = Math.Sin(x);
            else
                y = Math.Cos(x);
            Console.WriteLine("y = " + y);
        }
    }
}
