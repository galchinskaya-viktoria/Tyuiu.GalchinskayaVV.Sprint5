using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint5.Task4.V13.Lib;
using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.GalchinskayaVV.Sprint5\InPutDataFileTask4V13.txt";

            string text = File.ReadAllText(path).Trim();
            text = text.Replace(',', '.');
            double x = double.Parse(text, CultureInfo.InvariantCulture);
            double expected = Math.Round(Math.Cos(x) + (x * x) / 2.0, 3);

            DataService ds = new DataService();
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
