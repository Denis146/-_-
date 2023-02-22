//12. Напишите программу, которая будет 
// 1) принимать на вход два числа и 
// 2) выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("введите любые два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Multiplicity(number1, number2);

if (result == 0) Console.WriteLine($"число -> {number1} кратно {number2}");
else Console.WriteLine($"число -> {number1} НЕ кратно {number2} , остаток от деления " + result);


int Multiplicity(int num1, int num2)
{
    return num1 % num2;
}
