// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите положительное число: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);

if (isNumberN != true)
{
    Console.WriteLine("Ошибка! Вы ввели не число!");
    return;
}

if (N < 0)
{
    Console.WriteLine("Ошибка! Вы ввели отрицательное число!");
    return;
}

int[] GetCube(int N)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = (int)Math.Pow((i + 1), 3);
    }
    return arr;
}

void PrintGetCube()
{
    int[] arr = GetCube(N);
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintGetCube();