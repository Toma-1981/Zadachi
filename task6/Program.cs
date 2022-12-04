// Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным(делится ли оно без остатка)

Console.Write("Введите число ");
int x = int.Parse(Console.ReadLine()!);


if (x % 2 == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
