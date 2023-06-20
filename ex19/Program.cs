/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.Write("Введите пятизначное число для проверки является ли оно палиндромом: ");
int num = int.Parse(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    if (num/10000 == num%10 && num/1000%10 == num%100/10)
        Console.WriteLine($"{num} -> да");
    else Console.WriteLine($"{num} -> нет");
}
else Console.WriteLine($"{num} -> это не пятизначное число");