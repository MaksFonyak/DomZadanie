﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine($"Введите первое (целое) число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите второе (целое) число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите третье (целое) число ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine($"{max} Наибольшее число из трех");