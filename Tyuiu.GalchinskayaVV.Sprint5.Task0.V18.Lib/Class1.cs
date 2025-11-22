using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task0.V18.Lib
{
    public class Class1 : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            double y = x / Math.Sqrt(x * x + x);
            double result = Math.Round(y, 3);

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(filePath, result.ToString("0.000", CultureInfo.InvariantCulture));

            return filePath;
        }
    }
}
