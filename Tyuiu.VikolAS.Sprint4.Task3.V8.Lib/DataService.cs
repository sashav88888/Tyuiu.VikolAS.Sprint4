using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VikolAS.Sprint4.Task3.V8.Lib
{
    public class DataService : ISprint4Task3V8
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int colIndex = 3; // четвёртый столбец (индексация с 0)
            int min = array[0, colIndex];

            for (int i = 1; i < rows; i++)
            {
                if (array[i, colIndex] < min)
                {
                    min = array[i, colIndex];
                }
            }

            return min;
        }
    }
}
