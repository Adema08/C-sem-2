// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Is it a multiple of 7 and 23?");
if (x % 7 == 0 && x % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}