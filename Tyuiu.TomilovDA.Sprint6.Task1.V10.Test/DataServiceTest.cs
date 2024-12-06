using Tyuiu.TomilovDA.Sprint6.Task1.V10.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = new double[] { 4 };
            CollectionAssert.AreEqual(ds.GetMassFunction(0, 0), res);
        }
    }
}