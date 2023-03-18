// 57. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// набор данных {1, 9, 9, 0, 2, 8, 0, 9}
// 0 встречается 2 раза
// 1 встречается 1 раза
// 2 встречается 1 раза
// 8 встречается 1 раза
// 9 встречается 3 раза

// набор данных 
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раза
// 4 встречается 1 раза
// 6 встречается 2 раза

// Методы ---------------------------------------------------------

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
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

int[] MatrixToArray(int[,] matrix)
{
    int c = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[c] = matrix[i, j];
            c += 1;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

void SumElemArray(int[] array)
{
    int count = 1;
    int curentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == curentNumber) count++;
        else
        {
            Console.WriteLine($"число {curentNumber} встречается {count} раз");
            curentNumber = array[i];
            count = 1;
        }
    }
    Console.Write($"число {curentNumber} встречается {count} раз");
}


// Программа ---------------------------------------------------------
int[,] matrix = CreateMatrixRndInt(3, 3, 1, 10);
int[] arr = MatrixToArray(matrix);

PrintMatrix(matrix);
Console.WriteLine();

PrintArray(arr);
Console.WriteLine();

Array.Sort(arr);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine();
SumElemArray(arr);