using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint4.Task7.V29.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateSumEven()
        {
            DataService ds = new DataService();

            string value = "983157642891";
            int result = ds.Calculate(4, 3, value);

            // Четные: 8, 6, 2, 8 → сумма = 24
            Assert.AreEqual(24, result);
        }
    }
}
