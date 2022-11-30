// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[4];
if ((arr[0] == arr[4]) && (arr[1] == arr[3]))
{Console.WriteLine($"Число {num} - полиндром: ");} 
else
Console.WriteLine($"Число {num} -не полиндром: ");
