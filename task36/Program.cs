// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// найдите сумму элементов стоящих на нечетных позициях.
//[3,7,23,12]-> 19
//[-4,-6,89,6]-> 0
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
Console.Write("]");

int count = 0;
int res =0;
foreach (int el in array)
{
    if(el%2!=0) res+=el;
    {
        count++;
    }
}

Console.WriteLine($" ---> {res}");
