// **Задание 1:**Напишите программу,
//  которая на вход принимает два числа и выдаёт,
//   какое число большее,.

Console.Clear();
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if ( a > b)
{
    Console.WriteLine($"Максимальное число {a}");
}
else
{
    Console.WriteLine($"Максимальное число {b}");
}