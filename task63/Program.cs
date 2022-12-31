// Задача 63: Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

string LineNumbers(int n)
{
    return(n>=2)? LineNumbers(n-1) + $"{n} " : "1 ";
}
Console.WriteLine(LineNumbers(10));


void LineNumbers2(int n)
{
    if(n!=1) LineNumbers2(n-1);
    Console.Write($"{n} ");
}
LineNumbers2(5);

