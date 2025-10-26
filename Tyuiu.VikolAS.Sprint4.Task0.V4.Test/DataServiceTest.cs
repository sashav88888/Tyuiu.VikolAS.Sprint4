using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint4.Task0.V4.Lib;

namespace Tyuiu.VikolAS.Sprint4.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            int res = ds.GetMultEvenArrEl(array);

            Assert.AreEqual(32, res); // 8 * 4 = 32
        }
    }
}
