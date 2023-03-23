// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.WriteLine("введите натуральное число M ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите натуральное число N ");
int number2 = int.Parse(Console.ReadLine());


SumNumber(number1, number2, 0);

void SumNumber(int num1, int num2, int res)
{
        if (num1 > num2)
    {
        Console.WriteLine ($" Сумма {res}");
        return;
    }
    res = res + (num1++);
    SumNumber(num1, num2, res);
}
