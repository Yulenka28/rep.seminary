// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int[] fibon = new int[a];
if ( a > 2)
{
    fibon[0] = 0;
    fibon[1] = 1;
    for (int i = 2; i < fibon.Length; i++)
    {
        fibon[i] = fibon[i - 2] + fibon[i - 1];
    }
    for ( int j = 0; j < fibon.Length; j++)
    {
        Console.Write(fibon[j] + " ");
    }
}
else
{
    Console.Write("Введите число больше 2: первая последовательность будет 0 и 1");
}