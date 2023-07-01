// Задача 37: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];

Console.WriteLine("Исходный массив: ");
for (int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");