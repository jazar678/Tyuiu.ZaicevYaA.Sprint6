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

            string content = File.ReadAllText(path);

            // Удаляем все скобки и лишние символы
            content = content.Replace("[", "").Replace("]", "").Replace("(", "").Replace(")", "")
                            .Replace("{", "").Replace("}", "").Replace("\r", "").Replace("\n", "");

            // Разделяем по запятым
            string[] stringValues = content.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> numbers = new List<double>();

            foreach (string stringValue in stringValues)
            {
                string cleanValue = stringValue.Trim();
                if (double.TryParse(cleanValue, NumberStyles.Float, CultureInfo.InvariantCulture, out double num))
                {
                    numbers.Add(Math.Round(num, 3));
                }
            }

            return numbers.ToArray();
        }
    }
}