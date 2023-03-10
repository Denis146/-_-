// 41.Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел Пользователь

int Prompt(string message)
{
    System.Console.Write(message);          // вывести сообщение
    string value = Console.ReadLine();      // считывает с консоли строку
    int result = Convert.ToInt32(value);    // преобразует строку в целое число
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt ($"Введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine ($"a [{i}] = {array[i]}");
    }
}

int SumPositivDigit(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int lenght = Prompt("Введите количество элементов -> ");
int[] array;
array = InputArray(lenght);

PrintArray(array);

Console.WriteLine ($"количесьво чисел больше 0 - {SumPositivDigit(array)} ");
