﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Enter 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
    Console.Write($"{a} is divisible by {b}");
}
else
{
    Console.Write($"Remainder of the division: {a % b}");
}