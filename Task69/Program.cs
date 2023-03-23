// 69. Напишите программу, 
// которая на вход принимает два числа А и В 
// и возводит число А в целую степень В с помощью рекурсии

// А=3; В = 5 -> 243 (3 в степени 5)
// А=2; В = 3 -> 8

Console.WriteLine("введите натуральное число А ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("введите натуральное число В ");
int power = int.Parse(Console.ReadLine());

if (power < 0) Console.WriteLine("ошибка ввода");
else Console.WriteLine($"{number} в степени {power} = {PowNumber(number, power)}");

int PowNumber(int num, int pow)
{
    if (pow == 0) return 1;
    else return num * PowNumber(num, pow - 1);
}
