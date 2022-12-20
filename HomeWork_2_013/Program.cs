﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int BringThreeOut(int number)
{
    return number % 10;
}

int BringThreeOut1(int number)
{
    return number / 10 % 10;
}

int BringThreeOut2(int number)
{
    return number / 100 % 10;
}

int BringThreeOut3(int number)
{
    return number / 1000 % 10;
}

int a;

Console.WriteLine("Введите натуральное целое число");

a = int.Parse(System.Console.ReadLine()!);

int threeOut = BringThreeOut1(a);
int threeOut1 = BringThreeOut2(a);
int threeOut2 = BringThreeOut3(a);

if (a >= 1000 && a <= 9999)
{
    System.Console.WriteLine($"Третья цифра числа {a} - {BringThreeOut1(a)}");
}
else if (a >= 10000 && a <= 99999){
    System.Console.WriteLine($"Третья цифра числа {a} - {BringThreeOut2(a)}");
}
else if (a >= 100000 && a <= 999999){
    System.Console.WriteLine($"Третья цифра числа {a} - {BringThreeOut3(a)}");
}
else {
    System.Console.WriteLine($"Третья цифра числа {a} - {BringThreeOut(a)}");
}
