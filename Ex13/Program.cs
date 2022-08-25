int FindThirdNumber(int number)
{
    int numberNext = number;
    int number3 = numberNext;
    int error = -1;
    if (number / 100 > 0)
    {
        while (numberNext / 100 > 0)
        {
            number3 = numberNext % 10;
            numberNext = numberNext / 10;
        }
        return number3;
    }
    else
    {
        return error;
    }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = FindThirdNumber(number);

if (result == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(result);
}