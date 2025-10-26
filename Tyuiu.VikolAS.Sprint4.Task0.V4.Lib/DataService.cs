using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VikolAS.Sprint4.Task0.V4.Lib
{
    public class DataService : ISprint4Task0V4
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int mult = 1;
            bool hasEven = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    mult *= array[i];
                    hasEven = true;
                }
            }

            if (!hasEven)
            {
                mult = 0;
            }

            return mult;
        }
    }
}
