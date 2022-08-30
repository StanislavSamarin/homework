// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов массива:");
bool isNumberQ = int.TryParse(Console.ReadLine(), out int Q);

if (isNumberQ != true || Q <= 0)
{
    Console.WriteLine("Ошибка! Вы ввели не число, либо оно отрицательное!");
    return;
}

int[] GetArray(int Q)
{
    int[] array = new int[Q];
    bool isNumberN = true;
    int[] error = new int[Q];
    for (int i = 0; i < Q; i++)
    {
        Console.WriteLine($"Введите число {i + 1}:");
        isNumberN = int.TryParse(Console.ReadLine(), out int N);
        if (isNumberN != true)
        {
            Console.WriteLine("Ошибка! Вы ввели не число!");
            error[i] = 0;
            return error;
        }
        else
        {
            array[i] = N;
        }
    }
    return array;
}

void PrintArray()
{
    int[] array = GetArray(Q);
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
    Console.Write("]");
}

PrintArray();