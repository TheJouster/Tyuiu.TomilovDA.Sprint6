using Tyuiu.TomilovDA.Sprint6.Task2.V6.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double[] res = new double[] { 0.57 };
            CollectionAssert.AreEqual(res, dataService.GetMassFunction(0, 0));
        }
    }
}