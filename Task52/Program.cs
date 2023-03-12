// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] AverageSumColoumn(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        arr[j] = sum / matrix.GetLength(0);
        arr[j] = Math.Round(arr[j], 2, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintAvArray(double[] arr)
{
    Console.WriteLine($"средне арифметическое по столбцам: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],5} ");
        else Console.Write($"{arr[i],5}");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

double[] averageSumColoumn = AverageSumColoumn(array2d);
PrintAvArray(averageSumColoumn);