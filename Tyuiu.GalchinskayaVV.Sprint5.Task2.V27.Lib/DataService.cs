using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task2.V27.Lib
{
    public class DataService : ISprint5Task2V27
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(matrix[i, j]);
                    if (j < cols - 1)
                    {
                        sb.Append(";");
                    }
                }
                sb.AppendLine();
            }

            File.WriteAllText(path, sb.ToString());
            return path;
        }
    }
}
