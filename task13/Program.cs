// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает что третьей цифры нет.

Console.Write("Введите число a = ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine($"Третьей цифры нет ");
}
else
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int thirdNumber = num % 10;
    Console.WriteLine($"Третья цифра числа --> {thirdNumber}");
}