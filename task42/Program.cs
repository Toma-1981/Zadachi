// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45--> 101101
// 3 --> 11
// 2 --> 10

/*45%2 = 22 -> 1
22%2 = 11 -> 0
11%2 = 5 -> 1
5%2 = 2 -> 1
2%2 = 1 -> 0
1%2 = 0 -> 1*/
/*Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine ($" Число {num} конвертировали в двоичное ");


string numDouble = " ";
while(res >= 0)
{
    int res = num%2;
    numDouble = numDouble + res;
    num = res;
}
Console.WriteLine(numDouble);*/

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string result = " ";

int num;
while (a > 0)
{
    num = a % 2;
    result = num + result;
    a = a / 2;
}
Console.WriteLine($"конвертация в двоичное число: {result}");


