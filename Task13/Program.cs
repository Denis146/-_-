// Напишите программу, которая выводит третью цивру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("введите число  ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 999)
number = number / 10;

if (number >= 100 && number <= 999)
{
    int newNumber = ThirdDigit(number);
    Console.WriteLine($" -> {newNumber}");
}
else Console.Write("третей цифры нет");


int ThirdDigit(int num)
{
    return num % 10;
}