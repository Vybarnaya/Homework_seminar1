//задание 2:**Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c:");
int c = int.Parse(Console.ReadLine());
int max = a;
if (a>b)
{
    Console.WriteLine($"Число {a} максимальное");
} 
else
if (b>c) 
{
    Console.WriteLine($"Число {b} максимальное");
}
else
{
    Console.Write($"Число {c} максимальное");
}
