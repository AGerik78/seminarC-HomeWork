/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int TableOfCubes(int n)
{
    int i = 1;
    while (i <= n)
    {
        System.Console.Write(i * i * i + ", ");
        i++;
    }
    return n;
}

System.Console.Write("Введите натуральное число: ");
int n = int.Parse(System.Console.ReadLine()!);

int cubes = TableOfCubes(n);



