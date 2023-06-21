// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());
int num_0 = Math.Abs(a);
int i = 1;

while (num_0 > i)
{
    num_0 = num_0 / 10;
    i++;
}
Console.WriteLine(i);
