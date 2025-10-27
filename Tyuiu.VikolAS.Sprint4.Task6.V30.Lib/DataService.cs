using System;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VikolAS.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            List<string> result = new List<string>();

            foreach (string item in array)
            {
                if (item.Length > 5)
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
