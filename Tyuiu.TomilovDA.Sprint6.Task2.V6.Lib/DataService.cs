using System.IO.IsolatedStorage;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TomilovDA.Sprint6.Task2.V6.Lib
{
    public class DataService : ISprint6Task2V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass = new double[(stopValue-startValue)+1];
            int num = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i - 0.7 != 0)
                {
                    mass[num] = Math.Round((Math.Cos(i) / (i - 0.7)) - Math.Sin(i) * 12 * i + 2, 2);
                }
                else
                {
                    mass[num] = 0;
                }
                num++;
            }
            return mass;
        }
    }
}
