namespace Tyuiu.TomilovDA.Sprint6.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExists()
        {
            string path = @"C:\Sprint6Task5\InPutDataFileTask5V27.txt";
            FileInfo file = new FileInfo(path);
            Assert.IsTrue(file.Exists);
        }
    }
}