// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());


a = (a  % 100 ) / 10;
Console.WriteLine(a);
// a = a / 10;
// Console.WriteLine(a);
// a = a % 10;
// Console.WriteLine(a);
Console.WriteLine($"Вторая цифра: {a}");
