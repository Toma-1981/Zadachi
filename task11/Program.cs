// Напишите программу, которая выводит случайное трехзначное
// число и удаляет вторую цифру этого числа.

int numberN = new Random().Next(100, 999); 
Console.WriteLine(numberN);

int a = numberN%10;
int b = a + numberN/100*10;

Console.Write("Результат без второй цифры ");
Console.WriteLine(b);
