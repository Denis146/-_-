// 30. Напишите программу, которая
// выводит массив из 8 элементов, 
// аполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

Console.WriteLine("количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(num);
Console.WriteLine($"получили массив из {num} элементов: ");
PrintArray(array);

int[] FillArray(int num)
{
    Random rand = new Random();
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = rand.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}