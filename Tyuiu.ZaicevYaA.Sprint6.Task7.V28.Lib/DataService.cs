using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Изменяем в седьмой строке (индекс 6) числа не равные 13 на 0
            for (int j = 0; j < columns; j++)
            {
                if (matrix[6, j] != 13)
                {
                    matrix[6, j] = 0;
                }
            }

            return matrix;
        }
    }
}