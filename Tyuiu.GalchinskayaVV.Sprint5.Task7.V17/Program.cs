using System;
using Tyuiu.GalchinskayaVV.Sprint5.Task7.V17.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Task 7 | Вариант 17";

            Console.WriteLine("***************************************************************");
            Console.WriteLine("* Спринт #5                                                   *");
            Console.WriteLine("* Задание 7. Вариант 17                                       *");
            Console.WriteLine("* Удалить все удвоенные 'нн' из файла и сохранить результат. *");
            Console.WriteLine("***************************************************************");

            string path = @"C:\Users\1\source\repos\Tyuiu.GalchinskayaVV.Sprint5\InPutDataFileTask7V17.txt";

            DataService ds = new DataService();
            string outFile = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат сохранён в файл:");
            Console.WriteLine(outFile);

            Console.ReadKey();
        }
    }
}
