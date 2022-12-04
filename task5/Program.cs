// Напишите программу, которая на вход принимает одно число N, 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число N = "); 

int N = int.Parse(Console.ReadLine()!); 

int a = -N;

while (a < N+1)

{
    Console.Write(" " + a + " ");
    a = a + 1;
}
