using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TomilovDA.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] massFunction = new double[(stopValue-startValue)+1];
            for (int i = 0; i < massFunction.Length; i++)
            {
                if (((3 * i) + 0.5) != 0)
                {
                    massFunction[i] = Math.Round(Math.Sin(i) + (2 / ((3 * i) + 0.5)) - 2 * Math.Cos(i) * 2 * i);
                }
                else
                {
                    massFunction[i] = 0;
                }
            }
            return massFunction;
        }
    }
}
