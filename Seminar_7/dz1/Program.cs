// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] matrix = new double[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Math.Round(new Random().NextDouble(), 2);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}