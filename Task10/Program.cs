// Напишите программу, которая
// на вход принимает трехзначное число и
// на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("введите трехзначное число  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int newNumber = SecondDigit(number);
    Console.WriteLine($" -> {newNumber}");
}
else Console.Write("это не трехзначное число");


int SecondDigit(int num)
{
    return num % 100 / 10;
}

