﻿/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1  */

Console.WriteLine("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество колонок: ");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, colmns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-99, 100);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}