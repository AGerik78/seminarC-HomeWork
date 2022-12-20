/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a, b, c;

Console.WriteLine("Введите первое натуральное целое число");

a = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите второе натуральное целое число ");

b = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите третье натуральное целое число ");

c = int.Parse(System.Console.ReadLine()!);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

System.Console.WriteLine($"Максимальное число {max}");
