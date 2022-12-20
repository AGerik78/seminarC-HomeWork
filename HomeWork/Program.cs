/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int a, b;

Console.WriteLine("Введите первое число");

a = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите второе число ");

b = int.Parse(System.Console.ReadLine()!);

if ( a > b)
{
    System.Console.WriteLine($"Болшее число {a}, а меньшее число {b}");
}
else
{
    System.Console.WriteLine($"Большее число {b}, а меньшее число {a}");
}