// 29. Напишите программу, которая задает массив из 8 элементов, 
// заполненный псевдослучайными числами
// и выводит их на экран
// 1, 2, 5, 7, 19 -> [1,2,5,7,19]
// 6, 1, 33 -> [6,1,33]


int[] array = new int[8];

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100);
}
Console.Write("[");
Console.Write(string.Join(", ", array));
Console.WriteLine("]");
