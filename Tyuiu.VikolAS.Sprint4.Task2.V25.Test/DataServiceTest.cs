using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint4.Task2.V25.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 4, 3, 7, 6, 8, 5, 9, 4, 3, 8, 6 };

            int result = ds.Calculate(array);

            // Чётные элементы: 4, 6, 8, 4, 8, 6 → 4*6*8*4*8*6 = 36864
            Assert.AreEqual(36864, result);
        }
    }
}
