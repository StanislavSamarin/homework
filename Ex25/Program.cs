// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите любое число:");
bool isNumberN1 = int.TryParse(Console.ReadLine(), out int N1);

if (isNumberN1 != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

Console.WriteLine("Введите натуральное число:");
bool isNumberN2 = int.TryParse(Console.ReadLine(), out int N2);

if (isNumberN2 != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

if (N2 <= 0)
{
    Console.WriteLine("Ошибка! Вы ввели не натуральное число!");
    return;
}

int RaiseTheNumber(int N1, int N2)
{
    int result = 1;
    for (int i = 0; i < N2; i++)
    {
        result = result * N1;
    }
    return result;
}

Console.WriteLine(RaiseTheNumber(N1, N2));