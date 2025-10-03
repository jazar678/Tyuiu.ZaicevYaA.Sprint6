using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string str, string path)
        {
            string result = "";

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (words.Length >= 2)
                        {
                            result += words[words.Length - 2] + " ";
                        }
                    }
                }

                if (result.Length > 0)
                {
                    result = result.Trim();
                }
            }
            catch (Exception ex)
            {
                result = "Ошибка: " + ex.Message;
            }

            return result;
        }
    }
}