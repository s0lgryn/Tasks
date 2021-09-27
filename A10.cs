using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Таня: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Митя: ");
            int y = int.Parse(Console.ReadLine());
            double medium = (x + y) / 2;
            double Tdiff = x-medium;
            double Mdiff = y-medium;
            Console.WriteLine("Средний возраст : " + medium + " Разница Тани: " + Tdiff + " Разница Мити: " + Mdiff);
        }
    }
}
