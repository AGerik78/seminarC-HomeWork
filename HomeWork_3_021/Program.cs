/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double DistBetweenPoints(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double dx2 = (xA - xB) * (xA - xB);
    double dy2 = (yA - yB) * (yA - yB);
    double dz2 = (zA - zB) * (zA - zB);
    double S = dx2 + dy2 + dz2;
    S = Math.Sqrt(S);
    return S;
}
System.Console.WriteLine("Введите координаты первой точки по x");
double xA;
xA = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координаты первой точки по y");
double yA;
yA = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координаты первой точки по z");
double zA;
zA = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координаты второй точки по x");
double xB;
xB = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координаты второй точки по y");
double yB;
yB = double.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите координаты второй точки по z");
double zB;
zB = double.Parse(System.Console.ReadLine()!);


double point = DistBetweenPoints(xA, yA, zA, xB, yB, zB);

System.Console.WriteLine($"Расстояние между точками = {point:f}");