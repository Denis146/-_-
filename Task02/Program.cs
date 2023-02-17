// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// Пример
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("напишите любые два целых числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2) Console.WriteLine($"{number1} максимальное число");
else if (number1 == number2) Console.WriteLine($"{number1} и {number2}  равные числа");
else Console.WriteLine($"{number2} максимальное число");