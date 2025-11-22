using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint5.Task2.V27.Lib;
using System.IO;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileValid()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 1, 4, 3 },
                { 1, 1, 4 },
                { 4, 3, 8 }
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(3, lines.Length);

            string[] row1 = lines[0].Split(';');
            string[] row2 = lines[1].Split(';');
            string[] row3 = lines[2].Split(';');

            Assert.AreEqual("0", row1[0]);
            Assert.AreEqual("4", row1[1]);
            Assert.AreEqual("0", row1[2]);

            Assert.AreEqual("0", row2[0]);
            Assert.AreEqual("0", row2[1]);
            Assert.AreEqual("4", row2[2]);

            Assert.AreEqual("4", row3[0]);
            Assert.AreEqual("0", row3[1]);
            Assert.AreEqual("8", row3[2]);
        }
    }
}
