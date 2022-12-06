// Напишите программу, которая принимает на вход число N
// и выдает таблицу квадратов чисел от 1 до N.
// например: 5--> 1,4,9,16,25 ;  2--> 1,4.

Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int num = 1;
while(num<N+1)
{
    int result = num*num;
    Console.Write(result + ",");
    num++;
}
