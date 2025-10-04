using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V22.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\TestDataSprint6\InPutFileTask6V22.txt";

            string testData = "Первая строка файла\nВторая строка текста\nТретья строка данных";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("", path);
            string wait = "Первая Вторая Третья";

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCollectTextFromFileWithEmptyLines()
        {
            string path = @"C:\TestDataSprint6\InPutFileTask6V22.txt";

            string testData = "Слово1 слово2\n\nСлово3 слово4\n   \nСлово5 слово6";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("", path);
            string wait = "Слово1 Слово3 Слово5";

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InvalidFilepath()
        {
            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("", @"C:\Nonexistent\file.txt");
        }
    }
}