// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
bool isNumberLength = int.TryParse(Console.ReadLine(), out int length);

if (isNumberLength != true || length <= 0)
{
    Console.WriteLine("Ошибка! Вы ввели не число, либо оно отрицательное!");
    return;
}

// Получили количество вводимых чисел

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        bool isNumber = int.TryParse(Console.ReadLine(), out int number);
        if (isNumber != true)
        {
            Console.WriteLine("Ошибка! Вы ввели не число!");
            array[i] = -1;
            return array;
        }
        array[i] = number;
    }
    return array;
}

int[] array = FillArray(length);

// Получили массив введённых чисел

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int count = CountPositiveNumbers(array);
Console.WriteLine($"Количество положительных чисел: {count}");

// Получили количество положительных чисел среди введённых