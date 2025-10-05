using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string result = "";

            foreach (string line in lines)
            {
                // Проверяем, содержит ли строка символы "**"
                if (line.Contains("**"))
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '-', '(', ')', '[', ']', '"' },
                                              StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Ищем слова содержащие 'g' (регистронезависимо)
                        if (word.IndexOf('g', StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            result += word + " ";
                        }
                    }
                }
            }

            return result.Trim();
        }
    }
}