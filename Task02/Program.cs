// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// Пример
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("напишите любые два целых числа");
int namber1 = Convert.ToInt32(Console.ReadLine());
int namber2 = Convert.ToInt32(Console.ReadLine());
if (namber1 > namber2) Console.WriteLine($"{namber1} максимальное число");
else if (namber1 == namber2) Console.WriteLine($"{namber1} и {namber2}  равные числа");
else Console.WriteLine($"{namber2} максимальное число");