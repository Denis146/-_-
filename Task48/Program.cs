// 48. Задайте двумерный массив размера m на n
// каждый элемент в массиве находится по формуле:
// Amn = m+n
// выведите полученный массив на экран

// m=3, n=4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];  // [rows, colums] это значит [0, 1]
    // Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)    // внешний цикл, для прохода по строкам //  matrix.GetLength(0) или rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}");         // , 3} это форматирование строк, отступ 3 знака
            else Console.WriteLine($"{matrix[i, j],3}");
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);