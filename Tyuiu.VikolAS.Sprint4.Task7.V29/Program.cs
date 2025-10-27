using System;
using Tyuiu.VikolAS.Sprint4.Task7.V29.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task7.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "983157642891";
            int n = 4;
            int m = 3;

            Console.Title = "Спринт #4 | Викол А.С. | Таск 7 | Вариант 29";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Викол Александр Сергеевич | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дана строка из цифр \"983157642891\". Преобразовать её в матрицу 4x3 и   *");
            Console.WriteLine("* подсчитать сумму чётных чисел.                                          *");
            Console.WriteLine("***************************************************************************\n");

            int result = ds.Calculate(n, m, value);

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("\nМатрица 4x3:");

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(value[index] + " ");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСумма чётных чисел: " + result);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
