using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint4.Task4.V26.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 5, 4, 1, 1, 2 },
                { 3, 2, 4, 3, 5 },
                { 5, 2, 3, 2, 2 },
                { 2, 5, 1, 1, 4 },
                { 5, 3, 4, 3, 2 }
            };

            int[,] expected =
            {
                { 0, 4, 0, 0, 2 },
                { 0, 2, 4, 0, 0 },
                { 0, 2, 0, 2, 2 },
                { 2, 0, 0, 0, 4 },
                { 0, 0, 4, 0, 2 }
            };

            int[,] result = ds.Calculate(matrix);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}
