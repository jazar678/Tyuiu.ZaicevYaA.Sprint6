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
            string[] lines = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                // Проверяем, содержит ли строка символы "**"
                if (line.Contains("**"))
                {
                    // Разбиваем строку на слова
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '-', '(', ')', '[', ']', '"', '/', '\\', '+', '=', '|', '{', '}', '<', '>' },
                                              StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Проверяем содержит ли слово букву g (игнорируя регистр)
                        if (word.IndexOf('g', StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            if (result.Length > 0)
                                result.Append(" ");
                            result.Append(word);
                        }
                    }
                }
            }

            return result.ToString();
        }
    }
}