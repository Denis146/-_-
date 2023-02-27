// 28. Напишите программу, которая
// принимает на вход число N и 
// выдает произведение чисел от 1 до N 
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое, положительное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int composition = CompNumbers (number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {composition}");

int CompNumbers (int num) // num = number
{
    int comp = 1;
    for (int i = 1; i <= num; i++)
    {
        comp = comp * i;
    }
    return comp;
}