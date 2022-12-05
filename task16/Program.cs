// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.

Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine()!);

if (a == b*b)
{
    Console.Write("Да, первое число является квадратом второго.");
}
else
{
   Console.Write("Нет, первое число не явялется квадратом второго."); 
}
if (b == a*a)
{
    Console.WriteLine("Да,второе число является квадратом первого");
}
else
{
   Console.WriteLine("Нет, второе число не явялется квадратом первого."); 
}