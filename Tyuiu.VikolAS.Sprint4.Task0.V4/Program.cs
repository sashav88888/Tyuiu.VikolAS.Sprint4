using System;
using Tyuiu.VikolAS.Sprint4.Task0.V4.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            Console.Title = "Спринт #4 | Выполнил: Викол А.С. | Таск 0 | Вариант 4";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Викол Александр Сергеевич | ИИПб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив из 10 элементов в диапазоне от 0 до 9.                       *");
            Console.WriteLine("* Найти произведение чётных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            int result = ds.GetMultEvenArrEl(array);

            Console.WriteLine($"\n\nПроизведение чётных элементов массива = {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
