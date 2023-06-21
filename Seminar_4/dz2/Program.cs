// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;

while (a != 0)
{
    b = b + a % 10;
    a = a / 10;
}
Console.WriteLine(b);