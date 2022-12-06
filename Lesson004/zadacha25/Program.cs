// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int Expon(int a, int  b)
{
    int count = 1;
    int expon = a;
    while(count < b)
    {
        expon = expon * a;
        count++;
    }
    return expon;
}
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Expon(a, b));