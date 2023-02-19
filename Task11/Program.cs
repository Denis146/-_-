// вывести любое трехзначное число
// и первого и последнего числа получить новое число
// наприме: 328 -> 38


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначеное число => {number}");

// первый вариант решения:

// int firstDigit = number / 100;
// int lastDigit = number % 10;
// int newNumber = firstDigit * 10 + lastDigit;

// Console.WriteLine($"первое число -> {firstDigit}");
// Console.WriteLine($"второе число -> {lastDigit}");
// Console.WriteLine($"новое двухзначное число -> {newNumber}");

// второй вариант решения:

int newNumber = NewNumber(number);
Console.WriteLine($"новое двухзначное число -> {newNumber}");

int NewNumber(int num)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}