string weekends(int number)
{
    string yes = "Да";
    string no = "Нет";
    if (number == 6 || number == 7)
    {
        return yes;
    }
    else
    {
        return no;
    }
}

Console.WriteLine("Введите цифру от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());

string result = weekends(number);

if (number > 0 && number < 8)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка! Снова запустите программу и введите цифру от 1 до 7:");
}