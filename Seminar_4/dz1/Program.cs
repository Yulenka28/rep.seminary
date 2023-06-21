// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

double itog = Math.Pow(a, b);
Console.WriteLine(itog);