using Tyuiu.TomilovDA.Sprint6.Task4.V14.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValue()
        {
            DataService ds = new DataService();
            double[] res = new double[] { -5 };
            CollectionAssert.AreEqual(ds.GetMassFunction(0, 0), res);
        }
    }
}