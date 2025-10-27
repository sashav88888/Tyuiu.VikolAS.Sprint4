using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint4.Task5.V9.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculatePositiveCount()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { -2,  3,  0,  1, -1 },
                {  4, -3,  2,  0,  1 },
                {  0,  0, -4,  3,  2 },
                { -1, -2,  1,  4,  0 },
                {  3,  2, -3,  0, -4 }
            };

            // Положительные элементы: 3,1,4,2,1,3,2,1,4,3,2 → 11 элементов
            int expected = 11;
            int result = ds.Calculate(matrix);

            Assert.AreEqual(expected, result);
        }
    }
}
