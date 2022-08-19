Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    Console.Write("Большее число - ");
    Console.WriteLine(a);
    Console.Write("Меньшее число - ");
    Console.WriteLine(b);
}
else if (a == b) {
    Console.Write("Числа равны");
} else {
    Console.Write("Большее число - ");
    Console.WriteLine(b);
    Console.Write("Меньшее число - ");
    Console.WriteLine(a);
}