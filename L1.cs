using System;

namespace L1
{
    delegate int Operation(int x, int y);
    class Program
    {
        private static int Addition(int x, int y) { return x + y; }
        private static int Subtract(int x, int y) { return x - y; }
        private static int Multiply(int x, int y) { return x * y; }
        private static int Division(int x, int y) { return x / y; }
        static void Main(string[] args)
        {
            Operation operation = null;
            int x, y,res;
            char op;
            Console.WriteLine("Введите 1 число");

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }
            Console.WriteLine("Введите операцию");

            while (!char.TryParse(Console.ReadLine(), out op))
            {
                Console.WriteLine("Ошибка ввода! / * - +");
            }

            Console.WriteLine("Введите 2 число");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }

            switch (op)
            {
                case '+': operation += Addition; Console.WriteLine(operation?.Invoke(x, y)); break;
                case '/': operation += Division; Console.WriteLine(operation?.Invoke(x, y)); break;
                case '*': operation += Multiply; Console.WriteLine(operation?.Invoke(x, y)); break;
                case '-': operation += Subtract; Console.WriteLine(operation?.Invoke(x, y)); break;
            }

        }
    }
}
