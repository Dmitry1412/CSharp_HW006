/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

IntersectionPoint();

void IntersectionPoint()
{
System.Console.WriteLine("Введите через Enter значения b1, k1, b2, k2");
double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
if (k1 == k2 && b1 == b2) System.Console.WriteLine("Прямая лежит в прямой!");
else if (k1 == k2 && b1 != b2) System.Console.WriteLine("Прямые параллельны!");
else if (k1 != k2 && b1 == b2) System.Console.WriteLine("Точка пересечения в нуле");
else
{
    double resultX = (b2 - b1) / (k1 - k2);
    double resultY = k1 * resultX + b1;
    System.Console.WriteLine($"Прямые пересекутся в X: {resultX}, Y: {resultY}");
}
}
