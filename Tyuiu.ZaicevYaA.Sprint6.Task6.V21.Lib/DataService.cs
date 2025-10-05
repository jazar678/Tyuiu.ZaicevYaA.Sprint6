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
            string content = File.ReadAllText(path);

            // Разделяем содержимое на слова, используя различные разделители
            char[] separators = new char[] { ' ', '\r', '\n', '\t', ',', '.', '!', '?', ';', ':', '-', '(', ')', '[', ']', '"', '/', '\\' };
            string[] words = content.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Фильтруем слова, содержащие букву 'g' (регистронезависимо)
            var wordsWithG = words.Where(word =>
                word.IndexOf('g', StringComparison.OrdinalIgnoreCase) >= 0);

            // Объединяем результат через пробел
            return string.Join(" ", wordsWithG);
        }
    }
}