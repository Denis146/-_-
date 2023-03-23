// 65. Задайте значения M и N
// Напишите программу, которая выведет все натуральные числа в промежутке от  M до N

Console.WriteLine("введите натуральное число 1 ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите натуральное число 2 ");
int number2 = int.Parse(Console.ReadLine());

NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    else if (num2 > num1)
    {
        NaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else
    {
        Console.Write($"{num2} ");
    }
}
