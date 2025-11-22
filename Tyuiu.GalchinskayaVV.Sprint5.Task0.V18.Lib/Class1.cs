using System;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.GalchinskayaVV.Sprint5.Task0.V18.Lib
{
    public class Class1: ISprint5Task0V18
    {
        public double Calculate(int x)
        {
            double result = x / Math.Sqrt(Math.Pow(x, 2) + x);
            return Math.Round(result, 3);
        }

        public string SaveToFile(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double result = Calculate(x);

            File.WriteAllText(path, result.ToString());

            return path;
        }

        public string SaveToFileTextData(int x)
        {
            throw new NotImplementedException();
        }
    }
}