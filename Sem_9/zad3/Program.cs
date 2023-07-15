/* Задача 67: Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int Sum (int number)
{
    if (number == 0) return 0;
    int temp =number % 10 + Sum(number / 10);
    return temp;
    
}
Console.WriteLine(Sum(number));