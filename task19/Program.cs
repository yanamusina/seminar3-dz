// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("введите число: ");
string? str = Console.ReadLine();
if (str!.Length != 5)
{
    System.Console.WriteLine("вы ввели не пятизначное число");
}
else if (str[1] == str[3] && str[0] == str[4])
{
    System.Console.WriteLine("палиндром");
}
else
{
    System.Console.WriteLine("не палиндром");
}
