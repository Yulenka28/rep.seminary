// Программа на вход принимает число (может быть любой размерности). Необходимо вывести реверсивное число.
Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

if (num > 0)
{
    while ( num / 10 > 0)
    {
        count++;
        num = num / 10;
    }
}
else
{
    while ( num / -10 > 0)
    {
        count++;
        num = num / 10;
    }
}
Console.WriteLine($"Количество разрядов в числе: {count}");