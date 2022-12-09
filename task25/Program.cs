// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// например: 3, 5 -> 243 (3⁵)
//           2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A: ");
int numbera = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int numberb = int.Parse(Console.ReadLine()!);
int result = ToDegree(numbera,numberb);
Console.WriteLine($"Число {numbera} возведенное в степень числа {numberb} = {result}");
int ToDegree(int numa, int numb)
{
    int res = 1;
    for (int i = 1; i <= numb; i++)
    {
        res *= numa;
    }
    return (res);
}


