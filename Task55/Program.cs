// 55. Задайте двумерный массив
// Нпишите программу которая заменяет строки на столбцы.
// В случае, если это не возможно, программа должна вывести
// сообщение для пользователя.

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

void ChangeRowsColumsMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine($"ошибка");

    for (int i = 0; i < matrix.GetLength(0) - 1; i++)         //в цикле к дле добавил +1 и ниже i + 1, чтобы первый и последний элементы не менялись
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)   // чтобы цикл проходил один раз пишем i=j
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
    Console.WriteLine();
}


int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2d);

ChangeRowsColumsMatrix(array2d);
PrintMatrix(array2d);
