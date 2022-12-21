//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, b2 = 4, k1 = 5, k2 = 9 -> (-0,5; -0,5)


string X(double k1, double k2, double b1, double b2)
{
    string result = string.Empty;
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    result = $"({x} ; {y})";
    return result;
}
Console.WriteLine(X(5, 9, 2, 4));
