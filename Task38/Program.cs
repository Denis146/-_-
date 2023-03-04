// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)    // можно писать i<size или как записали это одно и тоже, но привязываемся уже к самому массиву
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;  // заполнение дабл цикла случайными значениями
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");    // идем по циклу до предпослднего элемента и ставим запятую
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MaxElem(double[] arr)
{
    double max = Int32.MinValue;        // присваеваем минимальное значение
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElem(double[] arr)
{
    double min = Int32.MaxValue;    // присваеваем максимальное значение
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}


double[] array = CreateArrayRndDouble(5, 1, 15);
// array = Math.Round(double[] array, 2, MidpointRounding.ToZero);
PrintArrayDouble(array);

Console.WriteLine();

double maxElem = MaxElem(array);
maxElem = Math.Round(maxElem, 2, MidpointRounding.ToZero);
Console.WriteLine($"Максимальный элемент {maxElem}");

double minElem = MinElem(array);
minElem = Math.Round(minElem, 2, MidpointRounding.ToZero);
Console.WriteLine($"Минимальный элемент {minElem}");

double diff = maxElem - minElem;
diff = Math.Round(diff, 2, MidpointRounding.ToZero);
Console.WriteLine($"Сумма элементов {diff}");

