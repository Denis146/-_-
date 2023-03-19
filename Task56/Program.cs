// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];  // [rows, colums] это значит [0, 1]
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)    // внешний цикл, для прохода по строкам //  matrix.GetLength(0) или rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

static void SumStringMatrix(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line += matrix[index, j] + " ";
    }
    Console.WriteLine($"Строка с минимальной суммой элементов {line} ");
}



int[,] array2d = CreateMatrixRndInt(3, 3, 1, 5);
PrintMatrix(array2d);
Console.WriteLine();

SumStringMatrix(array2d);

// комментарий учителя:
// По задаче 56 суммы вычсляются правильно, номер строки с наименьшей суммой программа не показывает.
// Также недочёт - метод, определяющий строку с наименьшей суммой выводит результат в консоль. Вывод данных - другая подзадача.