// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m, m];
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
int[,] NewArray = new int[m, m];
for(int j= 0; j < m; j++)
{
    for (int i = 0; i < m; i++)
    {
        NewArray[j,i] = array[i, j];
    }
}

for(int j= 0; j < m; j++)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"{NewArray[j, i]} ");
    }
    Console.WriteLine();
}