// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

if (num1 % 7 == 0)
{
    if (num1 % 23 == 0)
    {
        Console.WriteLine("Введеное число кратно 7 и 23");
    }
    else 
    {
        Console.WriteLine("Введеное число не кратно 7 и 23");
    }
}
else
{
    Console.WriteLine("Введеное число не кратно 7 и 23");
}