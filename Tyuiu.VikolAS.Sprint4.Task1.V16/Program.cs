using System;
using Tyuiu.VikolAS.Sprint4.Task1.V16.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Викол А.С. | Таск 1 | Вариант 16";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Викол Александр Сергеевич | ИИПб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный массив из 13 элементов (значения от 3 до 8).             *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[13];

            Console.WriteLine("\nВведите 13 целых чисел от 3 до 8 через пробел:");
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            int result = ds.Calculate(array);

            Console.WriteLine($"\n\nПроизведение нечетных элементов массива = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
