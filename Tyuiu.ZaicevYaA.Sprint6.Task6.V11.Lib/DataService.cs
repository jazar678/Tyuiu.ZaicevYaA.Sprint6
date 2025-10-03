using System;
using System.IO;
using System.Linq;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib
{
    public class DataService
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string result = "";

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (words.Length >= 2)
                    {
                        string secondLastWord = words[words.Length - 2];
                        result += secondLastWord + " ";
                    }
                }
            }

            return result.Trim();
        }
    }
}