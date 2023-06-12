// Задача 1: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int number3 = number2 * number2;

if (number1 == number3)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else 
{
    Console.WriteLine("Не является квадратом");
}