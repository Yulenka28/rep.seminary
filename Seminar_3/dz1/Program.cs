// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int b = 0;
int c = num;

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число! Попробуйте снова.");
    Environment.Exit(0);
}

 while (num != 0)
{
    b = (b * 10) + (num % 10);
    num = num / 10;
}
Console.Write(b);

if (c == b) 
{
    Console.WriteLine("Данное число является палиндромом.");
}
else
{
    Console.WriteLine("Данное число не является палиндромом.");
}