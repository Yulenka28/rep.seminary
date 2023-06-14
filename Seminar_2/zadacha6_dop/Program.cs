// Программа на вход принимает число (может быть любой размерности). Необходимо вывести реверсивное число.
Console.WriteLine("Введите любое число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;

 while (a != 0)
    {
        b = a % 10;
        a = a / 10;
        Console.Write(b);
    }
