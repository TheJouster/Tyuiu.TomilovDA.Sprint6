using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TomilovDA.Sprint6.Task3.V6.Lib
{
    public class DataService : ISprint6Task3V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 2)
                    {
                        if (matrix[i,j] % 2 == 0)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
            }
            return matrix;
        }
    }
}
