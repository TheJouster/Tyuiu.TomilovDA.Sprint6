using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TomilovDA.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] massFunction = new double[(stopValue - startValue) + 1];
            int el = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((Math.Sin(i) + 1) != 0)
                {
                    massFunction[el] = Math.Round((2 * i) - 4 + ((2 * i - 1)/(Math.Sin(i)+1)), 2);
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
