using System;
using System.IO;
using Tyuiu.GalchinskayaVV.Sprint5.Task3.V17.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение F(x) при x = 3, результат сохранить в бинарный файл  *");
            Console.WriteLine("***************************************************************************");

            int x = 3;

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

            double value;
            using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                value = br.ReadDouble();
            }

            Console.WriteLine("Результат F(3): {0:0.000}", value);
            Console.WriteLine("Файл: " + path);

            Console.ReadKey();
        }
    }
}
