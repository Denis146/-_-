// 67. Напишите программу,
// которая будет принимать на вход число и 
// возвращать сумму его цифр
// 453 -> 12 

Console.WriteLine("введите натуральное число 1 ");
int number = int.Parse(Console.ReadLine());

SumNumber(number);

int SumNumber(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumNumber(num / 10); // сначала считает все методы (деление) и складывает значения в стек 453/10, 45/10, 4/10. Затем берет остаток от деления на 10 и складывает
        // Console.WriteLine($"{num} ");
} 
Console.WriteLine($"{SumNumber(number)} ");