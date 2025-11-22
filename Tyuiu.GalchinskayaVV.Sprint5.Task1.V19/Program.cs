using System;
using System.IO;
using Tyuiu.GalchinskayaVV.Sprint5.Task1.V19.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint5.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Табулировать функцию F(x) на [-5; 5] с шагом 1 и сохранить в файл       *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Результаты табулирования (x; F(x)):");
            Console.WriteLine("-----------------------------------");

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Файл с результатами: " + path);
            Console.ReadKey();
        }
    }
}
