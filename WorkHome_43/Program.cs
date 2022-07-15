// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Задайте значения k1, b1, k2, b2 через пробел, соответственно:");
string[] numbers = Console.ReadLine()!.Split(" ");
double k1 = double.Parse(numbers[0]);
double b1 = double.Parse(numbers[1]);
double k2 = double.Parse(numbers[2]);
double b2 = double.Parse(numbers[3]);

void FindingPointIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (k1 == k2 && b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (-b2 + b1) / (-k1 + k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
        if (k1 * k2 == 0) Console.WriteLine("Прямые перпендикулярны.");
    }
}

FindingPointIntersection(k1, b1, k2, b2);