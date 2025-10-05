using System;
using System.IO;
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
                // Проверяем наличие ** в строке
                if (line.Contains("**"))
                {
                    // Разбиваем строку на слова по пробелам
                    string[] parts = line.Split(' ');

                    foreach (string part in parts)
                    {
                        // Проверяем содержит ли часть букву g и не является ли **
                        if ((part.Contains("g") || part.Contains("G")) && part != "**")
                        {
                            if (result.Length > 0)
                                result.Append(" ");
                            result.Append(part);
                        }
                    }
                }
            }

            return result.ToString();
        }
    }
}