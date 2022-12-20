/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N;

Console.WriteLine("Введите натуральное целое число больше 1");

N = int.Parse(System.Console.ReadLine()!);

int count = 1;

while (count <= N)
{
    if (count % 2 == 0)
    {
        System.Console.WriteLine(count);
    }
    count++;
}

// Хотел сделать чтобы при вводе 0 и 1 запрашивало на повторный ввод, не получилось((...

/*if (N = 0)
{
    System.Console.WriteLine("Вы ввели слишком маленькое число");
    N = int.Parse(System.Console.ReadLine()!);
}
else
{
    while (count <= N)
    {
        if (count % 2 == 0)
        {
            System.Console.WriteLine(count);
        }
        count++;
    }

}
*/