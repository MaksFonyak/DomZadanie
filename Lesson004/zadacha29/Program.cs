// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
int[] PrintArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(0, 99);
    }
    return array;
}
int len = 8;
int[] array = PrintArray(len);
for (int i = 0; i < len; i++)
{
    Console.Write($"{array[i]} ");
}