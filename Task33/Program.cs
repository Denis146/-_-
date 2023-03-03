// 33. Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// 4; массив [6,7,19,345,3] -> нет 
// 3; массив [6,7,19,345,3] -> да 

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

// void FindDigit(int[] arr, int number)               // метод поиска числа в массиве
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == number) Console.Write("да");
//         else Console.Write(" нет ");
//     }
// }

bool FindDigit(int[] arr, int number)               // метод поиска числа в массиве
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(6, -10, 10);         // вызываем метод заполнения массива
PrintArray(array);
Console.WriteLine();

Console.WriteLine("введите число ");
int num = Convert.ToInt32(Console.ReadLine());

bool existnum = FindDigit(array, num);
Console.WriteLine(existnum ? "да" : "нет");    // вывод через бинарный оператор, перевели true/false на рус.яз