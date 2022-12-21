// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, с
//колько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


/*Console.Write("Введите числа через пробел: ");

int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

int Numbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine(Numbers(array));*/

void CountNumbers(string[] listNum)
{
    int count = 0;
    foreach (string el in listNum)
    {
        if (int.Parse(el)>0) count++;   
    }
    Console.Write($"Количество чисел > 0 = {count}");
}
Console.WriteLine("Введите чисела через пробел: ");
string[] list = (Console.ReadLine()!).Split(' ');
CountNumbers(list);