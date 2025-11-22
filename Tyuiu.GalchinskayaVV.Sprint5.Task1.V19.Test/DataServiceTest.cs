using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint5.Task1.V19.Lib;
using System.IO;
using System.Globalization;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileCreatedAndContainsValueForZero()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);
            bool found = false;

            foreach (string line in lines)
            {
                if (line.StartsWith("0;"))
                {
                    string[] parts = line.Split(';');
                    double value = double.Parse(parts[1], CultureInfo.InvariantCulture);
                    Assert.AreEqual(4.00, value);
                    found = true;
                    break;
                }
            }

            Assert.IsTrue(found);
        }
    }
}
