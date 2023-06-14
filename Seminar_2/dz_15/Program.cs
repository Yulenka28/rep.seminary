// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число от 1 до 7 включительно: ");
int number = int.Parse(Console.ReadLine());

switch(number)
{
    case (1):
        Console.WriteLine("Понедельник");
        break;
    case (2):
        Console.WriteLine("Вторник");
        break;
    case (3):
        Console.WriteLine("Среда");
        break;
    case (4):
        Console.WriteLine("Четверг");
        break;
    case (5):
        Console.WriteLine("Пятница");
        break;
    case (6):
        Console.WriteLine("Суббота, выходной!");
        break;
    case (7):
        Console.WriteLine("Воскресенье, выходной!");
        break;
    default:
        Console.WriteLine("Неверно введено число");
        break;  
}