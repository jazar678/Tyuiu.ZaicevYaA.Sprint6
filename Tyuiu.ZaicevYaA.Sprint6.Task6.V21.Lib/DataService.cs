using System;
using System.IO;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                return "Файл не существует";

            string[] lines = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                // Более надежная проверка на наличие "**"
                if (line.IndexOf("**", StringComparison.Ordinal) >= 0)
                {
                    // Упрощенное разделение на слова - только пробелы
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Проверяем содержит ли слово букву g (игнорируя регистр)
                        if (word.IndexOf('g', StringComparison.OrdinalIgnoreCase) >= 0 ||
                            word.IndexOf('G', StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            // Пропускаем пустые слова и сами символы "**"
                            if (!string.IsNullOrEmpty(word) && word != "**")
                            {
                                if (result.Length > 0)
                                    result.Append(" ");
                                result.Append(word);
                            }
                        }
                    }
                }
            }

            return result.ToString();
        }
    }
}