/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*int a;

Console.WriteLine("Введите натуральное целое трехзначное число");

a = int.Parse(System.Console.ReadLine()!);

int a2 = a / 10 % 10;
 

System.Console.WriteLine(a2);
*/

int GetTwoDigit(int number)
{
    return number = number / 10 % 10;
}


Console.WriteLine("Введите натуральное целое трехзначное число");

int number = int.Parse(System.Console.ReadLine()!);


System.Console.WriteLine($"Вторая цифра числа {number} - {GetTwoDigit(number)}");