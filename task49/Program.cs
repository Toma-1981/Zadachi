//Задача 49: Задайте двумерный массив. Найдите элементы, у 
//которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив выглядел вот так:

int[,] CreateNormalMatrix(int a, int b)
{
    int[,] matrix = new int[a, b];
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1,10);
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
    return matrix;    
}

void CreateSgrtMatrix(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for(int rows = 0; rows < array.GetLength(0); rows++ )
    {
        for(int columns = 0; columns < array.GetLength(1); columns++)
        {
            if(rows%2 == 0 && columns%2 == 0) newArray[rows, columns] = (int)Math.Pow(array[rows, columns], 2);
            else newArray[rows, columns] = array[rows,columns];
            Console.Write($"{newArray[rows, columns]} ");
        }
        Console.WriteLine("");
    }
}
CreateSgrtMatrix(CreateNormalMatrix(4, 4));