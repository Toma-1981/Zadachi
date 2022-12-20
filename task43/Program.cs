//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, b2 = 4, k1 = 5, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите четыре числа, после каждого нажмите ввод: ");
int b1 = int.Parse(Console.ReadLine()!);
int k1 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);
int k2 = int.Parse(Console.ReadLine()!);

string IntersectionPoint(int b1, int b2, int k1, int k2)
{
    string result = string.Empty;
    int x = 0;
    int y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    result = $"({x}, {y})";
    return result;
}
Console.WriteLine(IntersectionPoint(2, -3, -3, 2));