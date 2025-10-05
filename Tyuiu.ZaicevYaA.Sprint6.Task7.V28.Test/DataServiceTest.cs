using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ZaicevYaA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask7V28.csv";

            // Создаем тестовый файл
            string testData = "1;2;3;4;5\n6;7;8;9;10\n11;12;13;14;15\n16;17;18;19;20\n21;22;23;24;25\n26;27;28;29;30\n31;32;33;34;35\n36;37;38;39;40";
            File.WriteAllText(path, testData);

            int[,] result = ds.GetMatrix(path);
            int[,] wait = {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 },
                { 26, 27, 28, 29, 30 },
                { 0, 0, 0, 0, 0 }, // 7-я строка, все значения кроме 13 заменены на 0
                { 36, 37, 38, 39, 40 }
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}