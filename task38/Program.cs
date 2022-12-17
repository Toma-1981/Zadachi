// задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива
//[3, 7, 22, 2, 78] --> 76

int[] NewArray(int size)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 100);
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

void Difference(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max) max = array[j];
        if (array[j] < min) min = array[j]; 
    }
    Console.Write(max - min);
}
Difference(array);


