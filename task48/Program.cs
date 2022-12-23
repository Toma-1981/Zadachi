// Задача 48: Задайте двумерный массив размера m на n,  каждый элемент в массиве
//находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

int[,] CrateArray(int a, int b)
{
    int[,] matrix = new int[a,b];
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows,columns] = rows + columns;
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine("");
    }
    return matrix;
}
Console.WriteLine("Ведите размер массива М: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер массива N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("");
CrateArray(m, n);
Console.WriteLine("");