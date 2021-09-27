using System;
namespace С18
{
    class Program 
    {
        static void Main (string[] args)
        {
			string snumber = Console.ReadLine();
			int firstDigit = int.Parse(Convert.ToString(snumber[0]));
			int number = Convert.ToInt32(snumber);
			int counter = 0;
			int digit = 0;
			while (number > 0)
			{
				digit = number %10;
				if(digit == firstDigit) counter ++;
				number/=10;
			}
		digit = number;
			if(digit==firstDigit) counter++;
			Console.WriteLine($"Цифра {firstDigit} в числе {snumber} встречается {counter} раз");
		}
    }
}	
