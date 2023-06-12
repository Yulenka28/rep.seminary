// Напишите программу, которая на вход принимает число и выдает его квадрат
Console.Write("Введи целое число: ");
int number = int.Parse(Console.ReadLine()); 

// квадрат входного числа
int result = number * number;

// вывод результата
Console.Write($"Квадрат входного числа: {result}");
