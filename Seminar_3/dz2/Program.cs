// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите значение координаты x1: ");
int ax = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты y1: ");
int ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты z1: ");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты Х2: ");
int bx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты y2: ");
int by = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение координаты z2: ");
int bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2) + Math.Pow((bz - az),2));
Console.WriteLine($"Растояние межку точками равно: {result}"); 