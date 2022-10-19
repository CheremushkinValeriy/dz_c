// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 
// // 1. запросить  упользователя значение переменных 
// // 2. выразить переменную х из уровнения
// // 3. получить знвчение y
// // 4. метод по значениям массива с получением количества значений больше ноля
 
double b1 = GetNumber("Введите значение b1: ");
double k1 = GetNumber("Введите значение k1: ");
double b2 = GetNumber("Введите значение b2: ");
double k2 = GetNumber("Введите значение k2: ");
double x = LineIntersectionX(b1, k1, b2, k2);
double y = LineIntersectionY(k2, b2, x);
Console.WriteLine($"Точка перечсечения двух прямых-> ({x};{y})");
/////////////////////////////////////////////////////////
double GetNumber(string message)
{
    Console.Write(message);
    string userInput = Console.ReadLine() ?? "";
    double size = double.Parse(userInput);
    return size;
}
///////////////////////////////////////////////////////////////////////////
double LineIntersectionX(double b1, double k1, double b2, double k2)
{
    double x = ((b2 - b1)/(k1 - k2));
    return x; 
}
//////////////////////////////////////////////////////////////
double LineIntersectionY(double k2, double b2, double x)
{
    double y = ((k2 * x) + b2);
    return y; 
    }
