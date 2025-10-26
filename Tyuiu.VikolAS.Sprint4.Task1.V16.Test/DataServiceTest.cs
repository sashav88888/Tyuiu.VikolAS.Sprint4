using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint4.Task1.V16.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };

            int result = ds.Calculate(array);

            // Нечётные элементы: 3,7,3,7,3,3,3 → 3*7*3*7*3*3*3 = 71487
            Assert.AreEqual(71487, result);
        }
    }
}
