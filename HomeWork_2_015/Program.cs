/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
int Weekend1(int number)
{
    return number % 7;
}
/*int Weekend2(int number)
{
    return number % 7;
}
*/
int a;

Console.WriteLine("Хотите узнать этот день выходной или рабочий?");
Console.WriteLine("Введите число от 1 до 31");

a = int.Parse(System.Console.ReadLine()!);

int week = Weekend1(a);
//int sun = Weekend2(a);

if (week == 0)
{
    System.Console.WriteLine("Выходной день - Воскресение");
}
else if (week == 6){
    System.Console.WriteLine("Выходной день - Суббота");
}
else
{
    System.Console.WriteLine("Рабочий день!");
}