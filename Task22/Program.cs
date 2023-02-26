// 22. Напишите программу, которая
// принимает на вход число N 
// и выдает таблицу квадратов чисел от 1 до N 
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4


Console.WriteLine("введите любое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Square(N);


void Square(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 5}  -  {index * index}, 5"); // 5 в скобках выравнивает формат вывода чтобы цифры стояли ровно
        index++;
    }
}