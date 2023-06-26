// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[5] {5.6, 1.3, 3, 7.7, 9};

Console.WriteLine("Исходный массив: ");
for (int i =0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

double max = array[0];
double min = array[0];


for (int i =1; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }

}
for (int i =1; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }

}
double dif = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {dif}");