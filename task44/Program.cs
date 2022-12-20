// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

/*int num = int.Parse(Console.ReadLine()!);
int[] listFib = new int[num];
Console.Write(listFib[0]);
listFib[1] = 1;Console.Write(listFib[1]);
for (int i = 2; i < num; i++)
{
    listFib[i] = listFib[i-1]+listFib[i-2];
    Console.Write(listFib[i]);
}*/

 int Fibonacci(int n)
 {
     if (n == 1 || n == 2) return 1;
     else return Fibonacci(n - 1) + Fibonacci(n - 2);
 }
 for (int i = 1; i < 10; i++)
 {
     Console.Write(Fibonacci(i));
 }