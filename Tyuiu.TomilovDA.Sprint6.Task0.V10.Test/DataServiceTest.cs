using Tyuiu.TomilovDA.Sprint6.Task0.V10.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValue()
        {
            DataService dataService = new DataService();
            int exp = 0;
            Assert.AreEqual(exp,dataService.Calculate(0));
        }
    }
}