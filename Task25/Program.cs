// 25. Напиши цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.
// 3, 5 -> 243 (3s)
// 2, 4 -> 16

Console.WriteLine("введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите натуральное число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// if (number2 >= 1) Console.WriteLine("возведем чсло А в степень числа В:");
// else Console.WriteLine("введено не натуральное число В, попробуйте еще раз");

// Degree(number1, number2);
// // Console.WriteLine($"степень числа в: {degree}");

// void Degree(int num1, int num2)
// {
//     int degree = 1;
//     for (int i = 1; i <= num2; i++)
//     {
//         degree = degree * num1;
//     }
//     Console.WriteLine(degree);
// }

if (number2 > 0) Console.WriteLine("возведем чсло А в степень числа В:");
else Console.WriteLine ("введено не натуральное число В, попробуйте еще раз");

int degree = Degree(number1, number2);
Console.WriteLine($"А в степени числа B: {degree}");

int Degree(int num1, int num2)
{
    int degree = 1;
    for (int i = 1; i <= num2; i++)
    {
        degree = degree * num1;
    }
    return degree;
}