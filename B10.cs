using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D < 0)
                Console.WriteLine("Дискриминант меньше нуля, корней нет");
            if (D == 0)
            {
                double x = (-b / (2 * a));
				if (Math.Truncate(x) == x)
	                Console.WriteLine("x: " + x);
				else
					Console.WriteLine("Корень вещественный");
            }
            if (D>0)
            {
                double x1 = ((-b - Math.Sqrt(D)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(D)) / (2 * a));
				if((Math.Truncate(x1) == x1) || (Math.Truncate(x2) == x2))
				{
					Console.WriteLine("x1: " + Math.Round(x1,1));
					Console.WriteLine("x2: " + Math.Round(x2,1));
				}
                else
					Console.WriteLine("Корень вещественный");
            }
        }
    }
}
