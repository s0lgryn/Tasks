using System;
namespace С18
{
    class Program 
    {
        static void Main (string[] args)
        {
			int number = int.Parse(Console.ReadLine());
			int index = 0;
			int indexMin = 0;
			int indexMinS = 1;
			int min = number ;
			while (number > 0)
				{
				index++;
				int digit = number % 10;
				if (min > digit)
					{
					min = digit;
					indexMin = index;
					}
			number /= 10;
				}
		indexMinS = index-indexMin;
		Console.WriteLine("Минимальная цифра " + min + " от конца числа " + indexMin );
		Console.WriteLine("Минимальная цифра " + min + " от начала числа " + indexMinS);
		}
    }
}
