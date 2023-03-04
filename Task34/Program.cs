// Задача 34: Задайте массив 
// заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int QuantityPositiveDigit(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = CreateArrayRndInt(10, 100, 999);         // вызываем метод заполнения массива
PrintArray(array);

Console.WriteLine();

int quantityPositiveDigit = QuantityPositiveDigit(array);
Console.WriteLine($"количество {quantityPositiveDigit}");