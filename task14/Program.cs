// Напишите программу, которая на вход число
// и проверяет кратно ли оно одновременно 7 и 23


Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);

if (N%7 == 0 && N%23 == 0)
{
    Console.WriteLine ("-----> да");
}

else 
{
    Console.WriteLine ("----> нет ");
}
