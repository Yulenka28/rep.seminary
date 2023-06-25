// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int [] array = new int[7] {5, -1, 3, 7, -9, 12, 44};
Console.WriteLine("Введите искомое число: ");
int a = int.Parse(Console.ReadLine());

bool isFound = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == a)
    {
        isFound = true;
        break;
    }
}
Console.WriteLine((isFound ? "Да" : "Нет"));


    