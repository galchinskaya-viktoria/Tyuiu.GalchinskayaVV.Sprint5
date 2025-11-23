using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task3.V17.Lib
{
    public class DataService : ISprint5Task3V17
    {
        public string SaveToFileTextData(int x)
        {
            double fx = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;
            double result = Math.Round(fx, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                bw.Write(result);
            }

            return path;
        }
    }
}
