// 51. Задайте двумерный массив
// найдите сумму элементов, находящихся на главной диагонали
// с индексами (0,0), (1,1) и тд 
// например:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// суммы элементов главной диагонали: 1+9+2 = 12


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

int SumElemsMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)    // внешний цикл, для прохода по строкам //  matrix.GetLength(0) или rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j) sum += matrix[i, j];
        }
    }
    return sum;
}


int[,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);

int sumElemsMainDiagonal = SumElemsMainDiagonal(array2d);

Console.WriteLine($"Сумма элементов главной диагонали = {sumElemsMainDiagonal}");
