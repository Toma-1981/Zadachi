// Напишите программу, которая выводит случайное число из отрезка (10, 99)
// и показывает наибольшую цифру числа например: 78 -8, 12 -2, 85 -8.

int numberN = new Random().Next(10, 99); 
Console.WriteLine(numberN);

int a = numberN/10;
int b = numberN%10;
int max = a;

if (a > max ) max = a;
if (b > max ) max = b;

Console.Write("max ");
Console.WriteLine(max);


