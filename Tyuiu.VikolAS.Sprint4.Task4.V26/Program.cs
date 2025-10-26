using System;
using Tyuiu.VikolAS.Sprint4.Task4.V26.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Викол А.С. | Таск 4 | Вариант 26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Викол Александр Сергеевич | ИИПб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5 (значения от 1 до 5).                          *");
            Console.WriteLine("* Заменить все нечётные элементы массива на 0.                            *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("\nВведите элементы массива (5 строк по 5 чисел через пробел):");

            for (int i = 0; i < 5; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = Convert.ToInt32(input[j]);
                }
            }

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int[,] result = ds.Calculate(matrix);

            Console.WriteLine("\nИзменённый массив (нечётные элементы заменены на 0):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
