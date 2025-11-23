using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path).Trim();
            text = text.Replace(',', '.');
            double x = double.Parse(text, CultureInfo.InvariantCulture);

            double y = Math.Cos(x) + (x * x) / 2.0;
            return Math.Round(y, 3);
        }
    }
}
