string FindRange(string[] quaters, int q)
{
    string result = quaters[q - 1];
    return result;
}
string[] quaters = {
    "x > 0, y > 0", 
    "x < 0, y > 0", 
    "x < 0, y < 0", 
    "x > 0, y < 0", 
};
Console.Write("Введите номер четверти: ");
int q = Convert.ToInt32(Console.ReadLine());
if (q >= 1 && q <= 4)
{
    //Console.WriteLine(quaters[q - 1]);
    Console.WriteLine(FindRange(quaters, q));
}
else
{
    Console.WriteLine("Неправильный номер четверти");
}