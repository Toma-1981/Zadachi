// Задача 59: Задайтедвумерный массив из целых чисел. Напишите 
//программу, которая удалит строку и столбец, на пересечении которых 
//расположен наименьший элемент массива.

Console.Write("Ведите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Ведите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
PrintArray(NewArray(array, FindMinElem(array)));

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" {inArray[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int[] FindMinElem(int[,] matrix) // находим минимальный элемент
{
    int min = matrix[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                minI = i;
                minJ = j;
                min = matrix[i, j];
            }
        }
    }
    int[] Temporary = { minI, minJ };
    return Temporary;
}

int[,] NewArray(int[,] originalArray, int[] coordinati)
{
    int a = 0;
    int b = 0;
    int[,] result = new int[originalArray.GetLength(0) - 1, originalArray.GetLength(1) - 1];
    for (int i = 0; i < originalArray.GetLength(0); i++)
    {
         if (i != coordinati[0])
        {
            for (int j = 0; j < originalArray.GetLength(1); j++)
            {
                if (j != coordinati[1])
                {
                    result[a, b] = originalArray[i, j];
                    b++;
                }
            }
            a++;
            b = 0;
        }
    }
    return result;
}