using System.Timers;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TomilovDA.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] massFunction = new double[(stopValue-startValue)+1];
            int el = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (((3 * i) + 0.5) != 0)
                {
                    massFunction[el] = Math.Round(Math.Sin(i) + (2 / ((3 * i) + 0.5)) - 2 * Math.Cos(i) * 2 * i,2);
                }
                else
                {
                    massFunction[el] = 0;
                }
                el++;
            }
            return massFunction;
        }
    }
}
