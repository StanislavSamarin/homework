// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число:");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

if (isNumberN != true || N <= 0)
{
    Console.WriteLine("Ошибка! Вы ввели не натуральное число!");
    return;
}

int GetSum(int N)
{
    int result = 0;
    int number;
    while (N > 0)
    {
        number = N % 10;
        result = result + number;
        N /= 10;
    }
    return result;
}

Console.WriteLine(GetSum(N));