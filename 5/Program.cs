﻿﻿// 7.Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает **последнюю** цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзнфчное число N:");
int N = int.Parse(Console.ReadLine());
int a = N%100;
int b = a%10;
Console.WriteLine($"Последней цифрой числа {N} является {b} ");





