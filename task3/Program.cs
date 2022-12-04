//Напишите программу, которая будет выдавать 
//название для недели по заданному номеру.

Console.Write("Введите номер дня недели ");
int a = int.Parse(Console.ReadLine()!);

if (a==1)
{
    Console.WriteLine("День недели понедельник ");
}
if (a==2)
{
    Console.WriteLine("День недели вторник ");
}
if (a==3)
{
    Console.WriteLine("День недели среда ");
}
if (a==4)
{
    Console.WriteLine("День недели четверг ");
}
if (a==5)
{
    Console.WriteLine("День недели пятница ");
}
if (a==6)
{
    Console.WriteLine("Дунь недели суббота ");
}
if (a==7)
{
    Console.WriteLine("День недели восресенье ");
}
if (a>7)
{
    Console.WriteLine("Введены не корректные данные ");
}
