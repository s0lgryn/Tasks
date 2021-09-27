using System;
namespace D4
{
    class Program 
    {
        static void Main (string[] args)
        {
			int number = int.Parse(Console.ReadLine());
			int index = 0;
			int indexMax = 0;
			int indexMaxS = 1;
			int max = 0;
			while (number > 0)
				{
				index++;
				int digit = number % 10;
				if (max < digit)
					{
					max = digit;
					indexMax = index;
					}
			number /= 10;
				}
		indexMaxS = index-indexMax;
		Console.WriteLine("Максимальная цифра " + max + " от конца числа " + indexMax);
		Console.WriteLine("Максимальная цифра " + max + " от начала числа " + indexMaxS);
		}
    }
}
