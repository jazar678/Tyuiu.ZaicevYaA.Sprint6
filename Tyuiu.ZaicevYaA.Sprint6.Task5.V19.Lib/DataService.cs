using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // Фильтруем только целые числа
            double[] numbers = lines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Trim())
                .Where(line => double.TryParse(line, out double num) && num == Math.Truncate(num))
                .Select(line => double.Parse(line))
                .ToArray();

            return numbers;
        }
    }
}