// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу которая покажет количество четных чисел в массиве.
// Например [345, 897, 568, 234] --> 2

int[] NewArray(int size)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

void PrintArray(int[] size)
{
    for (int j = 0; j < size.Length; j++)
    {
        Console.Write(size[j]+ " ");
    }
}

int[] array = NewArray(4);

Console.Write("[");
PrintArray(array);
Console.Write("]");

int count = 0;

for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;

Console.WriteLine($" ---> {count}");

