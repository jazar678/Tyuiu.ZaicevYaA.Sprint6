using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
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
                        string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (words.Length > 0)
                        {
                            result += words[0] + " ";
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
                throw new Exception("Ошибка при чтении файла: " + ex.Message);
            }

            return result;
        }
    }
}
