using System.Numerics;
using Tyuiu.TomilovDA.Sprint6.Task7.V19.Lib;

namespace Tyuiu.TomilovDA.Sprint6.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string path = @"C:\Sprint6Task7\InPutDataFileTask7V19.csv";
            FileInfo file = new FileInfo(path);
            int[,] res = new int[,] { { 15, -8, 9, 12, -5, 2, 3, 4, 5, 9 },
                                    {2, 2, 2, 2, -5, 2, 9, -1, 2, -15},
                                    {- 18, -17, -5, 11, -20, 14, 11, 5, -19, -18},
                                    {13, -14, 6, 14, 11, 4, -15, 5, 14, 1},
                                    {- 10, 3, 5, -3, 4, 13, -18, 20, 2, -5},
                                    {12, -8, -10, 5, -8, 11, -10, 0, 0, 14},
                                    {- 1, -5, -7, 3, -4, -3, -20, -6, -2, -1},
                                    {- 12, -16, -18, -9, -15, 18, 0, -20, 18, 5},
                                    {- 8, 16, -13, -17, 10, 12, -14, 5, 2, -12},
                                    {1, -19, 6, -8, 1, 11, 1, -20, 10, 6},
                                   };
            if (file.Exists)
            {

                dataService.GetMatrix(path);
                CollectionAssert.AreEqual(dataService.GetMatrix(path),res);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}