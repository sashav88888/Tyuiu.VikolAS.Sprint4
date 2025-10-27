using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VikolAS.Sprint4.Task7.V29.Lib
{
    public class DataService : ISprint4Task7V29
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            // Заполняем матрицу значениями из строки
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            int sumEven = 0;

            // Считаем сумму четных чисел
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sumEven += matrix[i, j];
                    }
                }
            }

            return sumEven;
        }
    }
}
