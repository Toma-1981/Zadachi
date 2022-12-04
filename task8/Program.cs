// Напишите программу которая, на вход принимает число N и 
// на выходе показывает все четные числа от 1 до N.

 Console.Write("Введите число ");

int num = Convert.ToInt32(Console.ReadLine());
int res = 2;
       
while (res <= num)
    {
        Console.WriteLine(res);
        res += 2;
    }
