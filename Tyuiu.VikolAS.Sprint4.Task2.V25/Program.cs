using System;
using Tyuiu.VikolAS.Sprint4.Task2.V25.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Викол А.С. | Таск 2 | Вариант 25";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (случайные значения)                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Викол Александр Сергеевич | ИИПб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный массив из 11 элементов (значения от 3 до 9).             *");
            Console.WriteLine("* Подсчитать произведение чётных элементов массива.                       *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[11];
            Random rnd = new Random();

            Console.WriteLine("\nСформированный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(3, 10);
                Console.Write(array[i] + " ");
            }

            int result = ds.Calculate(array);

            Console.WriteLine($"\n\nПроизведение чётных элементов массива = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
