int middleNumber(int number)
{
    if (number / 1000 == 0 && number / 100 > 0)
    {
        int middleNumber = number % 100 / 10;
        return middleNumber;
    }
    else
    {
        int error = -1;
        return error;
    }
}

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = middleNumber(number);

if (result == -1)
{
    Console.WriteLine("Ошибка: Вы ввели не трёхзначное число. Снова запустите программу и введите трёхзначное число.");
}
else
{
    Console.WriteLine(result);
}
