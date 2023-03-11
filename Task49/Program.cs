// 49. Задайте двумерный массив. Найдите элементы,
// у которых оба индекс четные
// и замените эти элементы на их квадраты
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 
// заменим на:
// 1 4 49 2
// 5 9 2 3 
// 64 4 4 4


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}");         // , 3} это форматирование строк, отступ 3 знака
            else Console.WriteLine($"{matrix[i, j],5}");
        }
    }
}

void ReplacePositivElem(int[,] matrix)               // нужно заменить элементы, значи создавать новый массив не нужно, значит только передаем void
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i / 2 == 0 && j / 2 == 0) 
            matrix[i, j] *= matrix[i, j];               // *= matrix[i, j] то же что matrix[i, j] * matrix[i, j]
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);


ReplacePositivElem(array2d);
Console.WriteLine();
PrintMatrix(array2d);