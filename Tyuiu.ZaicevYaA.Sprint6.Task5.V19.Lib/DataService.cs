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
            double[] numbers = lines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line =>
                {
                    if (double.TryParse(line, out double result))
                        return Math.Round(result, 3);
                    return 0;
                })
                .ToArray();

            return numbers;
        }
    }
}