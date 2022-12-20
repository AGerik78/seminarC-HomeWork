/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/
//System.Console.WriteLine("Хотите узнать четное число или нет?");

int a;

Console.WriteLine("Введите натуральное целое число");

a = int.Parse(System.Console.ReadLine()!);

if (a % 2 == 0)
{
    System.Console.WriteLine("Да четное");
}
else
{
    System.Console.WriteLine("Нет не четное");
}