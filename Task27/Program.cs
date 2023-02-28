// 27. Напишите программу, которая
// принимает на вход число
// и выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите целое, положительное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int sumdigit = SumDigit(number);
Console.WriteLine($"сумма цифр в виденном числе {sumdigit}");

int SumDigit(int num)
{
    int result = 0;
    while (num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}