//Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.

int numberN = new Random().Next(100, 999); 
Console.WriteLine(numberN);

int a = numberN/10;
int b = a%10;

Console.Write("Вторая цифра ");
Console.WriteLine(b);