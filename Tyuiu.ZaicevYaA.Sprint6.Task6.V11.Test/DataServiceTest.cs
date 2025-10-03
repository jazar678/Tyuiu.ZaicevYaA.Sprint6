using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\test\InPutFileTask6V11.txt";
            string wait = "предпоследние слова";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile("", path);
            Assert.AreEqual(wait, res);
        }
    }
}