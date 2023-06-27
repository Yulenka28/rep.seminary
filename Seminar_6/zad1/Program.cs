// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Такой треугольник может существовать");
}
else
{
    Console.WriteLine("Такой треугольник не может существовать");
}