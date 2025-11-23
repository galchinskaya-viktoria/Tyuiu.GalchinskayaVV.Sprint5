using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint5.Task3.V17.Lib;
using System.IO;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckBinaryFileAndValue()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            Assert.IsTrue(File.Exists(path));

            double value;
            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                value = br.ReadDouble();
            }

            double expected = 68.3;
            Assert.AreEqual(expected, value, 0.001);
        }
    }
}
