using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VikolAS.Sprint4.Task4.V26.Lib
{
    public class DataService : ISprint4Task4V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] resMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        resMatrix[i, j] = 0;
                    }
                    else
                    {
                        resMatrix[i, j] = matrix[i, j];
                    }
                }
            }

            return resMatrix;
        }
    }
}
