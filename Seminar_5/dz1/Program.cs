﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];

Console.WriteLine("Исходный массив: ");
for (int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}

Console.WriteLine();
int count = 0;

for (int i =0; i < array.Length; i++)
{
    if (array[i] % 2 == 0 )
    {
        count = count + 1;
    }
}
Console.WriteLine($"Колличество четных чисел в массиве = {count}");