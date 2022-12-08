// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // 9012 -> 12



int sumNumbers(int num)
{
    int result = 0;
    num = Math.Abs(num);
    if (num < 10)
        result = num;
    else
    {
        int ind = num;
        while(ind > 0)
        {
            result = result + ind % 10;
            ind = ind /10;
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} равна {sumNumbers(num)}");