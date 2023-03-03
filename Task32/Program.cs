// 32. Напишите программу замены элементов массива
// положительные элементы замените на соответствующие отрицательные и наоборот

// [-4,-8,8,2] -> [4,8,-8,-2]

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
 

void ChangePositiveNegativeElem (int[] arr)            // метод замены значений массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
   
}

int[] array = CreateArrayRndInt(6, -10, 10);         // вызываем метод заполнения массива
PrintArray(array);
Console.WriteLine();

ChangePositiveNegativeElem (array);                 // вызываем метод замены значений массива
PrintArray(array);