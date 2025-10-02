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
            double[] numbers = new double[0];

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(' ');
                    foreach (string value in values)
                    {
                        if (double.TryParse(value, out double num))
                        {
                            Array.Resize(ref numbers, numbers.Length + 1);
                            numbers[numbers.Length - 1] = Math.Round(num, 3);
                        }
                    }
                }
            }

            return numbers;
        }
    }
}