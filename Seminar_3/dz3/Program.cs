// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
/*int result = 0;

for ( int i = 1; i <= a; i++)
{
    result = i * i * i;
    Console.Write($"{result} ");
} */

int n = 1;
while ( n <= a)
{
    Console.WriteLine(n * n * n);
    n++;
}