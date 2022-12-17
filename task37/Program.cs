﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем 
//первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] NewArray(int size)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 10);
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
Console.Write("]--> ");

int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)
{
    Console.Write(array[i] * array[j] + " ");
    j--;
}
