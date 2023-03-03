// 37. Найдите произведение пар чисел в одномерном массиве
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве
// [1 2 3 4 5 ] - 5 8 3
// [6 7 3 6 ] - 36 21

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



int[] CompositionNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;       // проверяем здесь на четность, смотрим на остаток от деления на 2

    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (newArray.Length % 2 != 0)
        newArray[newArray.Length - 1] = arr[size-1]; // определяем средний элемент
    return newArray;
}


int[] array = CreateArrayRndInt(9, 0, 20);         // вызываем метод заполнения массива
PrintArray(array);
Console.WriteLine();

int[] composarray = CompositionNumbers(array);
PrintArray(composarray);