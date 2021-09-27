using System;

namespace Console_Calculator
{
    class Calculator
    {
        public double Calculate(double a, char oper)
        {
            switch (oper)
            {
                case '+': return a + a;
                case '-': return a - a;
                case '*': return a * a;
                case '/': return a / a;
                default: return 0.0;
            }
        }
        public double Calculate(double a, char oper, double b)
        {
            switch (oper)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: return 0.0;
            }
        }
        public double Calculate(double a, double b, double c, char oper)
        {
            switch (oper)
            {
                case '+': return a + b + c;
                case '-': return a - b - c;
                case '*': return a * b * c;
                case '/': return a / b / c;
                default: return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            bool valid = false;
            while (!valid)
            {
                Console.Write("Сколько чисел желаете ввести?\n1\t2\t3\n");
                valid = char.TryParse(Console.ReadLine(), out char actions);
                if (actions == '1')
                {
                    Console.Write("format [a +]\n");
                    string input = Convert.ToString(Console.ReadLine());
                    string[] tmp = input.Split(' ');
                    Console.WriteLine(calc.Calculate(Convert.ToDouble(tmp[0]), Convert.ToChar(tmp[1])));
                }
                if (actions == '2')
                {
                    Console.Write("format [a + b]\n");
                    string input = Convert.ToString(Console.ReadLine());
                    string[] tmp = input.Split(' ');
                    Console.WriteLine(calc.Calculate(Convert.ToDouble(tmp[0]), Convert.ToChar(tmp[1]), Convert.ToDouble(tmp[2])));
                }
                if (actions == '3')
                {
                    Console.Write("format [a b c +]\n");
                    string input = Convert.ToString(Console.ReadLine());
                    string[] tmp = input.Split(' ');
                    Console.WriteLine(calc.Calculate(Convert.ToDouble(tmp[0]), Convert.ToDouble(tmp[1]), Convert.ToDouble(tmp[2]), Convert.ToChar(tmp[3])));
                }

            }

        }

    }
}
