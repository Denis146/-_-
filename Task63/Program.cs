// 63. Задайте значение N
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
// N = 5 -> "1, 2, 2, 4, 5"

Console.WriteLine("введите натуральное число");
int number = int.Parse(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}
// проверка на натуральность
