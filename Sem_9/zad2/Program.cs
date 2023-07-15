/* Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int FillNatural(int m, int n)
{
    if (m - 1 == n) return n;

    int temp = FillNatural(m, n - 1);
    Console.Write(n + " ");
    return temp;
    
}
FillNatural(m, n);
