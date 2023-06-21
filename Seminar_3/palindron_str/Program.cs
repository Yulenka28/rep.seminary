// Является ли число палиндромом, решение через строки
/*Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число! Попробуйте снова.");
    Environment.Exit(0);
}

string number_str = num.ToString();

if (number_str[0] == number_str[4] &&
    number_str[1] == number_str[3])
{
    Console.WriteLine("Ваше число палиндром.");
}
else
{
    Console.WriteLine("Ваше число не палиндром.");
} */

Console.WriteLine("Введите строку: ");
string user_str = Console.ReadLine();

string reverse_user_str = "";
for (int i = user_str.Length - 1; i >= 0; i--)
{
    reverse_user_str = reverse_user_str + user_str[i];
}

if (reverse_user_str == user_str)
{
    Console.WriteLine("Ваша строка палиндром");
}
else
{
    Console.WriteLine("Ваша строка не палиндром");
}