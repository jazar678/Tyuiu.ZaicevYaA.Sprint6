using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib;
using System.IO;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\test\testfile.txt";

            string testData = "первое второе третье\nодин два три\nслово1 слово2 слово3";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("test", path);

            string wait = "второе два слово2";
            Assert.AreEqual(wait, result);

            File.Delete(path);
        }
    }
}