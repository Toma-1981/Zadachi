// Напишите программу, которая принимает на 
//вход три числа и выдает максимальное из этих чисел.



Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите число с = ");
int c = int.Parse(Console.ReadLine()!);

 int max;
 if (a >= b)
 {
    if (c >= a)
    {
       max = c;
    }
    else
    {
       max = a;
    }
 }
 else
 {
    if (c >= b)
    {
       max = c;
    }
    else
    {
       max = b;
    }
 }
 Console.Write(max);
