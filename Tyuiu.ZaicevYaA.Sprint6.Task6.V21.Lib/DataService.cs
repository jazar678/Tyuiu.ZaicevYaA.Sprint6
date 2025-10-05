using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string str, string path)
        {
            string result = "";

            if (!File.Exists(path))
                return "Файл не существует";

            try
            {
                string fileContent = File.ReadAllText(path);

                // Разделяем на слова, используя различные разделители
                char[] separators = new char[] {
                    ' ', ',', '.', '!', '?', ';', ':', '\t', '\r', '\n',
                    '(', ')', '[', ']', '{', '}', '"', '\'', '-', '_',
                    '=', '+', '*', '/', '\\', '|', '<', '>', '&', '%', '$', '@'
                };

                string[] words = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                // Фильтруем слова, содержащие букву 'g' (регистронезависимо)
                var filteredWords = words.Where(word =>
                    word.IndexOf("g", StringComparison.OrdinalIgnoreCase) >= 0);

                // Объединяем через пробел
                result = string.Join(" ", filteredWords);
            }
            catch (Exception ex)
            {
                return $"Ошибка при чтении файла: {ex.Message}";
            }

            return result;
        }
    }
}