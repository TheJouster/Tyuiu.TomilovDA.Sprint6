using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TomilovDA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] nums = new double[len];
            using (StreamReader sr = new StreamReader(path))
            {
                
                int index = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    double num = Convert.ToDouble(line);
                    if (num % 5 != 0)
                    {
                        nums[index] =Math.Round(num,3);
                        len++;
                    }
                    index++;
                }
                
            }
            nums = nums.Where(x => x % 5 != 0).ToArray();
            return nums;

        }
    }
}
