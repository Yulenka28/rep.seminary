/* Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int FillNatural(int n)
{
    
    if (n == 0) return 1;

    int temp = 1 + FillNatural(n - 1);
    Console.Write(" " + n);
    return temp;
    
}
FillNatural(number);