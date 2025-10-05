using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib;
using System.IO;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            // Создаем тестовый файл
            string path = @"C:\DataSprint6\InPutFileTask6V21.txt";

            // Создаем директорию если не существует
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Записываем тестовые данные
            string testData = "Первая строка без звездочек\n" +
                            "Вторая строка со ** звездочками nXkwQYzgZ LlckTwkpaAGTvLPc\n" +
                            "Третья строка XcNHugFmbsRgVVfsgHNGuUC ** текст\n" +
                            "Четвертая строка без g букв\n" +
                            "Пятая ** строка с g и G буквами";

            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);
            string waitResult = "nXkwQYzgZ XcNHugFmbsRgVVfsgHNGuUC g G";

            Assert.AreEqual(waitResult, result);
        }
    }
}