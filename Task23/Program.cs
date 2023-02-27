// 23. Напишите программу, которая
// принимает на вход число N и
// выводит таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите любое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);

void Cube(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 5}  -  {index * index, 4} - {index * index * index, 4}");
        index++;
    }
}