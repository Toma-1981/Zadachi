﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8



 int Fibonacci(int n)
 {
     if( n == 0) return 0;
     if (n == 1 || n == 2) return 1;
     else return Fibonacci(n - 1) + Fibonacci(n - 2);
 }
 for (int i = 0; i < 7; i++)
 {
     Console.Write(Fibonacci(i));
 }