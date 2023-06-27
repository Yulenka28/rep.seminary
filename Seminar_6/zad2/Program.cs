// Напишите программу, которая будет преобразовывать десятичное число в двоичное
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
string result = "";

while (N > 0)
{
   result = N % 2 + result;
   N = N / 2;
}

Console.WriteLine($"в двоичной системе {result}");