// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray(int size, int startValue, int endValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startValue, endValue + 1);
    }
    return array;
}

// Метод вывода массива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// для вызова методов:
int[] array = GetRandomArray(10, 100, 1000);
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine($"Количество положительных чисел в массиве = {count}");