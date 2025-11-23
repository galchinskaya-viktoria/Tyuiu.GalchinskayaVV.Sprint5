using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.GalchinskayaVV.Sprint5.Task7.V17.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadDataAndSave()
        {
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Анна написала длиннную стрееннную линию");

            DataService ds = new DataService();
            string resultPath = ds.LoadDataAndSave(inputPath);

            string resultText = File.ReadAllText(resultPath);

            string expected = "Ана написала длинную стреенную линию".Replace("нн", "");

            Assert.AreEqual(expected, resultText);
        }
    }
}
