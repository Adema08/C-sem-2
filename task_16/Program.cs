// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Enter 1st number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("One number is the square of another number?");
if (Math.Pow(a, 2) == b || Math.Pow(b, 2) == a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
