// 9. Напишите программу, которая
// 1. выводит случайное число из отрезка 10-99
// 2. и показывает наибольшее из них

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// реализация с помощбю функции
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
int MaxDigit(int num) // num = number  здесь создается копия
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;

    // if (firstDigit > secondDigit) return firstDigit;
    // else return secondDigit;
// или другим методом последние две строчки
// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// return result;
// или
 return firstDigit > secondDigit ? firstDigit : secondDigit;

}
int maxDigit2 = MaxDigit(94);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");
