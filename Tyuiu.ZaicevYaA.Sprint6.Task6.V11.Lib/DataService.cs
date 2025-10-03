using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.Courses.Sprint6;

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
                            string preLastWord = words[words.Length - 2];
                            result += preLastWord + " ";
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