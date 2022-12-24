﻿//Задача 50: Напишите программу, которая на вход  принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет. 
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a,b];
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void SearchPosition(int[,] array, int position)
{
    if(position%10 > array.GetLength(1) || position/10 > array.GetLength(0))
    Console.WriteLine($"\nЧисла со строкой {position/10} и позицией {position%10} в массиве нет");
    else Console.WriteLine($"\nЧисло строки {position/10} и позиции {position%10} = {array[position/10-1, position%10-1]}");
    
}

Console.WriteLine("Введите размер массива M*N (2 числа без пробела):");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию элемента массива для поиска X*Y (две цыфры без пробела): ");
//позиция != индекс 
int i = int.Parse(Console.ReadLine()!);
Console.WriteLine();
SearchPosition(CreateArray(size/10, size%10), i);
Console.WriteLine();