using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task3.V16.Lib
{
    public class DataService : ISprint6Task3V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] resultMatrix = new int[rows, columns];

            Array.Copy(matrix, resultMatrix, matrix.Length);

            for (int j = 0; j < columns; j++)
            {
                if (resultMatrix[2, j] % 2 == 0)
                {
                    resultMatrix[2, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}