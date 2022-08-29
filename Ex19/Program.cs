// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите положительное пятизначное число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (isNumber != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

bool ValidateNumber(int number)
{

    if (number < 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

bool isValid = ValidateNumber(number);

if (isValid == false)
{
    Console.WriteLine("Ошибка! Вы ввели отрицательное число!");
    return;
}


bool isFive = ValidateFive(number);

bool ValidateFive(int number)
{
    int i = 0;
    while (number > 0)
    {
        i++;
        number /= 10;
    }
    if (i == 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (isFive == false)
{
    Console.WriteLine("Ошибка! Вы ввели не пятизначное число!");
    return;
}

bool ValidateP(int number)
{
    int n = number;
    int[] arr = new int[5];
    for (int i = 0; i < 5; i++)
    {
        arr[i] = n % 10;
        n /= 10;
    }
    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool isPalindrome = ValidateP(number);
if (isPalindrome == true)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}