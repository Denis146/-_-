// 46. Задайте двумерный массив, размером m x N
// заполненный случайными целыми числами
// m =3, n=4




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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");         // , 3} это форматирование строк, отступ 3 знака
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);