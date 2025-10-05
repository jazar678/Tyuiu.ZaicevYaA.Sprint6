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
                if (line.Contains("**"))
                {
                    // Простое разделение по пробелам
                    string[] words = line.Split(' ');

                    foreach (string word in words)
                    {
                        if ((word.Contains('g') || word.Contains('G')) &&
                            !string.IsNullOrWhiteSpace(word) &&
                            word != "**")
                        {
                            if (result.Length > 0)
                                result.Append(" ");
                            result.Append(word);
                        }
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}