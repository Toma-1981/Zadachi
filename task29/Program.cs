// Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.

Console.Clear();
int n = 8;
int[] arr = new int[n];
Random rand = new Random();
int[] GetNewArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
        Console.Write(arr[i] +" ");

    }
    return arr;
}
GetNewArr(arr);
