// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
int[] array = new int[123];

Console.WriteLine("Исходный массив: ");
for (int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1000);
    Console.Write(array[i] + " ");
}
int quality = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
        quality = quality + 1;
    }
}
Console.WriteLine();
Console.WriteLine(quality);