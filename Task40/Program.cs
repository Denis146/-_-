// 40. Напишите программу, которая 
// принимает на вход три числа и проверяет может ли существовать 
// треугольник с сторонами такой длины.
// (теорема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы других сторон)

Console.WriteLine("Введите три целых, положительных числа:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());




bool TriangleExist(int num1, int num2, int num3)
{
    return number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2;
}

bool resalt = TriangleExist(number1, number2, number3);

Console.WriteLine(resalt ? "да" : "нет");