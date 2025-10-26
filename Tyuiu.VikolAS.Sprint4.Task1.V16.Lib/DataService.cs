using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VikolAS.Sprint4.Task1.V16.Lib
{
    public class DataService : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int mult = 1;
            bool hasOdd = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    mult *= array[i];
                    hasOdd = true;
                }
            }

            if (!hasOdd)
            {
                mult = 0;
            }

            return mult;
        }
    }
}
