// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double k1 = DataInput("Введите коэффициент k1 - ");
double b1 = DataInput("Введите коэффициент b1 - ");
double k2 = DataInput("Введите коэффициент k2 - ");
double b2 = DataInput("Введите коэффициент b1 - ");

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine($"Координаты точки пересечения прямых, заданных уравнениями y = {k1} * x + {b1}, y = {k2} * x + {b2} : ({x};{y})");

double DataInput(string str)
{
    Console.Write(str);
    double number = double.Parse(Console.ReadLine());
    return number;
}