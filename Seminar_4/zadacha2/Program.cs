// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());
int n = 1;

for (int i =1; i <= a; i++)
{
    n = n * i;
}
Console.WriteLine(n);