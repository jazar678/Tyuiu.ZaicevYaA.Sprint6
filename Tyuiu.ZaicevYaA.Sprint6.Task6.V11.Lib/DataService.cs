using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string str, string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
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
            }

            return result.Trim();
        }
    }
}