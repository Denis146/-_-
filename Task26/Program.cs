// 26. Напишите программу, которая
// принимает на вход число и 
// выдает количество цифр в чиселе
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

Console.WriteLine("Введите целое, положительное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = CheckDigit(number);
Console.WriteLine($"в виденном числе {digit} знаков");

int CheckDigit(int num)
{
    int result = 0;
    while (num != 0)
    {
        num = num / 10;
        result = result + 1;
    }
    return result;
}