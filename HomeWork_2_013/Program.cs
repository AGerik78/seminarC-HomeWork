/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


/*
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
*/

//int threeOut1 = BringThreeOut1(a);
//int threeOut2 = BringThreeOut2(a);
//int threeOut3 = BringThreeOut3(a);
/*
if (a >= 100 && a <= 999)
{
    System.Console.WriteLine($"Третья цифра числа {a} - {BringThreeOut(a)}");
}
else if (a >= 1000 && a <= 9999)
{
    System.Console.WriteLine($"Третья цифра числа {a} - {BringThreeOut1(a)}");
}
else if (a >= 10000 && a <= 99999)
{
    System.Console.WriteLine($"Третья цифра числа {a} - {BringThreeOut2(a)}");
}
else if (a >= 100000 && a <= 999999)
{
    System.Console.WriteLine($"Третья цифры числа {a} - {BringThreeOut3(a)}");
}
else
{
    System.Console.WriteLine($"Третей цифры числа {a} - нет");
}
*/
int BringThreeOut(int number)
{
    int i = 0;
    while (number >= 1000)    // || number <= -1000
    {
        number = number / 10;
        i++;
    }
    {
        number = number % 10;
    }
    return number;
}

Console.WriteLine("Введите натуральное целое число");

int a;

a = int.Parse(System.Console.ReadLine()!);

int threeOut = BringThreeOut(a);

if (a >= 100)   // || a <= -100
{
    System.Console.WriteLine($"Третья цифра числа {a} - {BringThreeOut(threeOut)}");
}
else
{
    System.Console.WriteLine($"Третей цифры числа {a} - нет");
}



/*
int[] array = { 5, 12, 31, 14, 15, 16, 17, 18 };

int n = array.Length;

int find = 12;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
*/

