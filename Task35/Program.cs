// 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива значения которых
// лежат в отрезке [10, 99]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)    // можно писать i<size или как записали это одно и тоже, но привязываемся уже к самому массиву
    {
        arr[i] = rnd.Next(min, max + 1);   // последнее значение не включено в диапазон (такие правила)), поэтому +1
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");    // идем по циклу до предпослднего элемента и ставим запятую
        else Console.Write($"{arr[i]}");                         // выводим последний элемент без запятой
    }
    Console.Write("]");
}

int[] array = CreateArrayRndInt(123, 0, 200);         // вызываем метод заполнения массива
PrintArray(array);

int FindRange(int[] arr, int num1, int num2)               
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    // int count = 0;
    {
        if (arr[i] >= num1 && arr[i] <= num2) count++;
        
    }
    return count;
}

Console.WriteLine();
Console.WriteLine("введите диапазон чисел в котором посчитать количество");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int findcountrange = FindRange(array, number1, number2);
Console.WriteLine($"количество {findcountrange}");   