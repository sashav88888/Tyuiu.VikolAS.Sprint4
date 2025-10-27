using System;
using Tyuiu.VikolAS.Sprint4.Task6.V30.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task6.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] array = { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            Console.Title = "Спринт #4 | Выполнил: Викол А.С. | Таск 6 | Вариант 30";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка строковых массивов                                      *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Викол Александр Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Дан строковый массив [Береза, Дуб, Клён, Сосна, Пихта, Осина].          *");
            Console.WriteLine("* Вывести элементы, длина которых больше 5 символов.                      *");
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array));

            string[] result = ds.Calculate(array);

            Console.WriteLine("\nРезультат (длина > 5):");
            if (result.Length > 0)
                Console.WriteLine(string.Join(", ", result));
            else
                Console.WriteLine("Нет элементов длиной более 5 символов.");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
