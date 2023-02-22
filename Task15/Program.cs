// Напишите программу, которая принимает на вход цифру
// обозначающую день недели и 
// проверяет является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите любые число соответствующее дню недели, посмотрим является ли оно выходным");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    if (Weekend(number)) Console.WriteLine("-> да");
    else Console.WriteLine("-> нет");

    bool Weekend (int num1)
    {
        return num1 == 7 || num1 == 6; 
    }
}
else Console.Write("вы ввили число не соответствующее дню недели");
