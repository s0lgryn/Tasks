using System;

namespace ConsoleApp3
{
    class Program
    {
        static int[,] SortEven(int row, int rows, int cols, int[,] mas)
        {
            for (var i = 1; i < cols; i++)
            {
                for (var j = 0; j < cols - i; j++)
                {
                    if (mas[row, j] < mas[row, j + 1])
                    {
                        var temp = mas[row, j];
                        mas[row, j] = mas[row, j + 1];
                        mas[row, j + 1] = temp;
                    }
                }
            }
            return mas;
        }
        static int[,] SortUneven(int row, int rows, int cols, int[,] mas)
        {

            for (var i = 1; i < cols; i++)
            {
                for (var j = 0; j < cols - i; j++)
                {
                    if (mas[row, j] > mas[row, j + 1])
                    {
                        var temp = mas[row, j];
                        mas[row, j] = mas[row, j + 1];
                        mas[row, j + 1] = temp;

                    }
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            int x, y;
            var Random = new Random();
            Console.Write("Input amount of rows: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Input amount of cols: ");
            y = int.Parse(Console.ReadLine());
            Console.Clear();
            int[,] matrix = new int[x, y];
            //Заполнение таблицы
            for (int rows = 0; rows < x; rows++)
            {
                Console.Write("{0,2}", rows);
                for (int cols = 0; cols < y; cols++)
                {
                    matrix[rows, cols] = Random.Next(1, 1000);
                    Console.Write("{0,4}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------");
            
            //Сортировк
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 1)
                    SortEven(i, x, y, matrix);
                else
                    SortUneven(i, x, y, matrix);

            }


            //Вывод матрицы
            for (int rows = 0; rows < x; rows++)
            {
                Console.Write("{0,2}", rows);
                for (int cols = 0; cols < y; cols++)
                    Console.Write("{0,4}", matrix[rows, cols]);
                Console.WriteLine();
            }
            int k = 0;
            Console.WriteLine("Input column number, start from 0");
            k = int.Parse(Console.ReadLine());
            for (int rows = 0; rows < x; rows++)
                Console.WriteLine(matrix[rows, k]);
            Console.ReadKey();
        }
    }
}
