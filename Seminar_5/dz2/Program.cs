// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[10];

Console.WriteLine("Исходный массив: ");
for (int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + " ");
}

Console.WriteLine();
int count = 0;

for (int i =1; i < array.Length; )
{
    count = count + array[i];
    i = i +2;
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {count}");