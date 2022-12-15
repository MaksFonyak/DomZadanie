// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        {
            Console.Write($"{arr[i]} ");
        }
    }
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        {
            arr[i] = new Random().Next(100, 1000);
        }
    }
}

int[] matrix = new int[6];


FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();