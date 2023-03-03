// 31. Задайте массив из 12 элементов
// заполненный случайными числами из промежутка [-9, 9]
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.

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


int[] GetSumPositiveNegativeElem(int[] arr)            // найдем суммы отрицательных и положительных элементов
{
    int sumNegative = 0;
    int sumPositive = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative += arr[i];
        else sumPositive += arr[i];
    }
    return new int[] { sumNegative, sumPositive };
}

int[] array = CreateArrayRndInt(12, -9, 9);         // теперь вызываем наш метод
PrintArray(array);
Console.WriteLine();                        // чтобы при выводе след. значений уйти на новую строку
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);     // здесь будет массив, который выводит два значения, сумму отрицательных и положительных

Console.WriteLine($"Сумма положительных чисел = {sumPositiveNegativeElem[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sumPositiveNegativeElem[0]}");

// если выводить суммы отдельнымим методами, будет так:
// int GetSumPositiveElem(int[] arr)            
// {
//     int sumPositive = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) sumPositive += arr[i];
//     }
//     return sumPositive;
// }
// и такой же метод для отрицательных