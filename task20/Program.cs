// Напишите программу которая принимает на вход координаты
//двух точек и находит расстояние между ними в 2D пространстве.

// А (3,6) В (2,1) --> 5,09
// A (7,-5) B (1,-1) --> 7,21

Console.Clear();
Console.Write("Введите координату хА ");
int xA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату yА ");
int yA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату хB ");
int xB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату yB ");
int yB = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt((xA-xB)*(xA-xB)+(yA-yB)*(yA-yB));
Console.WriteLine(result);