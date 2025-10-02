using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл {path} не найден");
            }

            string[] lines = File.ReadAllLines(path);
            List<double> numbers = new List<double>();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Обрабатываем каждую строку отдельно
                string cleanLine = line.Trim();

                // Удаляем все скобки
                cleanLine = cleanLine.Replace("[", "").Replace("]", "").Replace("(", "").Replace(")", "")
                                    .Replace("{", "").Replace("}", "");

                // Разделяем по запятым
                string[] stringValues = cleanLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string stringValue in stringValues)
                {
                    string cleanValue = stringValue.Trim();
                    if (double.TryParse(cleanValue, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                    {
                        numbers.Add(Math.Round(num, 3));
                    }
                }
            }

            return numbers.ToArray();
        }
    }
}