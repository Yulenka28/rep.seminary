// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое целое число: ");
int num = int.Parse(Console.ReadLine());

while (num > 1000)
{
    num = num / 10;
}
if (num > 99)
    {
        int result = num % 10;
        Console.WriteLine($"Третья цифра: {result}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет.");
    }
