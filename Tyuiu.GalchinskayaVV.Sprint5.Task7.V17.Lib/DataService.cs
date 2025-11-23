using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task7.V17.Lib
{
    public class DataService : ISprint5Task7V17
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string result = text.Replace("нн", "");

            string outPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V17.txt");

            File.WriteAllText(outPath, result);

            return outPath;
        }
    }
}
