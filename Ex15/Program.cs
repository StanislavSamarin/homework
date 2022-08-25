bool CheckWeekends(int number)
{
    if (number == 6 || number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите цифру от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());

bool result = CheckWeekends(number);

if (number < 1 || number > 7)
{
    Console.WriteLine("Ошибка! Снова запустите программу и введите цифру от 1 до 7:");
}
else if (result == true)
{
    Console.WriteLine("Да");
}
else if (result == false)
{
    Console.WriteLine("Нет");
}