// Задача 26: Напишите программу, которая принимает на вход число и 
//выдаёт количество цифр в числе. 
// Например: 456 -> 3 
//           78 -> 2 
//           89126 -> 5
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе = {GetCount (number) }");
int GetCount(int numTemp)
{
    int count = 0;
    while (numTemp > 0)
    {
        numTemp/=10;
        count ++;
    }
    return count;
}