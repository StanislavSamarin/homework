int thirdNumber(int number)
{
    int numberNext = number;
    int number3 = numberNext;
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
        int error = -1;
        return error;
    }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = thirdNumber(number);

if (result == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(result);
}