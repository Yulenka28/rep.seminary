// Программа выводит случайное число из отрезка (10-99) и показывает наибольшую цифру числа
// Случайное число от 10 до 99 включительно
int num = new Random().Next(10, 100);
Console.WriteLine($"Рандомное число: {num}");

int firstDigit = num / 10;
int secondDigit = num % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифрв ы числе: {firstDigit}");
}
else
{
    Console.WriteLine($"Наименьшая цифра  вчисле: {secondDigit}");
}