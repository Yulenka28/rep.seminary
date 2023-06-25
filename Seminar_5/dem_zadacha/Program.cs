// Создайте и заполните массив случайным образом от -9 до 9, найдите сумму всех положительных и негативных чисел.

// Метод для получения массива, заполненного случайным образом
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
int[] array = GetRandomArray(12, -9, 9);
PrintArray(array);

/*
//Создаем массив на 12 элементов
int[] array = new int[12];
// заполняем массив случайно от -9 до 9
Console.WriteLine("Исходный массив: ");
for (int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}
*/

Console.WriteLine();
int sum_pos = 0;
int sum_neg = 0;

for (int i =0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum_pos = sum_pos + array[i];
    }

    if (array[i] < 0)
    {
        sum_neg = sum_neg + array[i];
    }
}

Console.WriteLine($"Сумма положительных чисел массива = {sum_pos}");
Console.WriteLine($"Сумма отрицательных чисел массива = {sum_neg}");