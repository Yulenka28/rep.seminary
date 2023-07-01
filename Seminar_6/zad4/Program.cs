// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
double[] array = new double[new Random().Next(10, 20)];
Console.Write("Исходный массив: ");
for (int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.Write("Копия массива: ");
double[] copy = new double[array.Length];
for (int j = 0; j < array.Length; j++)
{
    copy[j] = array[j];
    Console.Write(copy[j] + " ");
}