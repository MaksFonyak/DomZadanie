﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = FillMatrixRnd(3, 4);
PrintMatrix(arr);
ReplaceRows(arr);
PrintMatrix(arr);


// Заполнение массива случайными числами
int[,] FillMatrixRnd(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Замена местами первую и последнюю строку массива
void ReplaceRows(int[,] matrix)
{
    int temp;
    int rows = matrix.GetLength(0) - 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0, j];
        if (temp < matrix[0, j])
        {
            temp = matrix[rows, j];
        }
    }
}