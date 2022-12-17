﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в 
//отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
int[] NewArray(int size)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 300);
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

int[] array = NewArray(123);

Console.Write("[");
PrintArray(array);
Console.Write("]");

int count = 0;

foreach (int el in array)
{
    if(el>= 10 && el <= 99)
    {
        count++;
    }
}

Console.WriteLine($" ---> {count}");