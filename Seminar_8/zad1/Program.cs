// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
for(int i= 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int buf;

for (int j = 0; j < array.GetLength(1); j++)
{
    buf = array[0, j];
    array[0, j] = array[m-1, j];
    array[m-1, j]= buf;
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}