// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0,51);
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarage = (avarage + matrix[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}