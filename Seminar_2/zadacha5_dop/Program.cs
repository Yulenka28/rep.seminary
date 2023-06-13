// Программа на вход принимает число (может быть любой размерности). Необходимо вывести количество цифр в этом числе.
Console.WriteLine("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

while ( num / 10 > 0)
{
    count++;
    num = num / 10;
}
Console.WriteLine($"Количество разрядов в числе: {count}");