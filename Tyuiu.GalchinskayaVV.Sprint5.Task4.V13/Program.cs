using System;
using Tyuiu.GalchinskayaVV.Sprint5.Task4.V13.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать x из файла и вычислить y = cos(x) + x^2 / 2                   *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\1\source\repos\Tyuiu.GalchinskayaVV.Sprint5\InPutDataFileTask4V13.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
