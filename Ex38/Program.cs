// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива:");
bool isNumberLength = int.TryParse(Console.ReadLine(), out int length);

if (isNumberLength != true || length <= 0)
{
    Console.WriteLine("Ошибка! Вы ввели не число, либо оно отрицательное!");
    return;
}

// Получили количество элементов в массиве

double[] FillArray(int length)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

double[] array = FillArray(length);

// Задали массив, состоящий из вещественных чисел от 0 до 99

double GetMaxElement(double[] array)
{
    double maxElement = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    return maxElement;
}

double maxElement = GetMaxElement(array);

// Нашли максимальный элемент массива

double GetMinElement(double[] array)
{
    double minElement = 100;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    return minElement;
}

double minElement = GetMinElement(array);

// Нашли минимальный элемент массива

void PrintArray(double[] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

PrintArray(array);

// Показали заданный массив

double difference = maxElement - minElement;
Console.WriteLine($"{difference}");

// Показали разницу между максимальным и минимальным элементом массива