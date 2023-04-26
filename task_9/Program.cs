// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int n = new Random().Next(10, 100);
Console.WriteLine($"Random number: {n}");
if (n / 10 > n % 10 )
{
    Console.WriteLine($"1st digit > 2nd digit and = {n / 10}");
}
else if (n / 10 == n % 10)
{
    Console.WriteLine($"2nd digit = 1st digit and = {n % 10}");
}
else
{
    Console.WriteLine($"2nd digit > 1st digit and = {n % 10}");
}