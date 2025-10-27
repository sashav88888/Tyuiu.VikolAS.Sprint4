using System;
using Tyuiu.VikolAS.Sprint4.Task5.V9.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            int[,] matrix = new int[5, 5];

            Console.Title = "Спринт #4 | Выполнил: Викол А.С. | Таск 5 | Вариант 9";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Викол Александр Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5 со случайными числами от -4 до 4.              *");
            Console.WriteLine("* Найти количество положительных элементов.                               *");
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 5);
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(matrix);

            Console.WriteLine("\nКоличество положительных элементов: " + result);
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
