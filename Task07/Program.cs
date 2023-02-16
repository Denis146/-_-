// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Write("введите трехзначное число  ");
int namber = Convert.ToInt32(Console.ReadLine());
if (namber >= 100 && namber <= 999)
{
    int lastnamber = namber % 10;
Console.Write($"последняя цифра числа --> {lastnamber}");
}
else Console.Write("это не трехзначное число");