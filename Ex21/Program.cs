// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x точки A");
bool isNumberXA = int.TryParse(Console.ReadLine(), out int xa);
if (isNumberXA != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите координату y точки A");
bool isNumberYA = int.TryParse(Console.ReadLine(), out int ya);
if (isNumberYA != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите координату z точки A");
bool isNumberZA = int.TryParse(Console.ReadLine(), out int za);
if (isNumberZA != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите координату x точки B");
bool isNumberXB = int.TryParse(Console.ReadLine(), out int xb);
if (isNumberXB != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите координату y точки B");
bool isNumberYB = int.TryParse(Console.ReadLine(), out int yb);
if (isNumberYB != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите координату z точки B");
bool isNumberZB = int.TryParse(Console.ReadLine(), out int zb);
if (isNumberZB != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

double GetLength(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
}

Console.WriteLine($"Расстояние между точкой A и точкой B равно {GetLength(xa,ya,za,xb,yb,zb)}");