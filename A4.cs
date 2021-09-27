using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длинна ребра: ");
            int a = int.Parse(Console.ReadLine());
            int volume = a*a*a;
            int square = a * a;
            Console.WriteLine("Объем куба: " + volume + " Площадь боковой поверхности: " + square);
        }
    }
}
