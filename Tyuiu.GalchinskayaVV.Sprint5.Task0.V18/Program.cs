using Tyuiu.GalchinskayaVV.Sprint5.Task0.V18.Lib;

Console.Title = "Спринт #5 | Выполнил: Гальчинская В. В. | ПКТб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.             *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* Выражение: y(x) = x / sqrt(x^2 + x)                                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 3;
Console.WriteLine($"x = {x}");

Class1 ds = new Class1();
double result = ds.Calculate(x);
string path = ds.SaveToFile(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Результат: {result}");
Console.WriteLine($"Файл сохранен: {path}");

Console.WriteLine("Содержимое файла:");
string fileContent = File.ReadAllText(path);
Console.WriteLine(fileContent);

Console.ReadKey();