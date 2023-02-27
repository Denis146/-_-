// 19. Напишите программу, которая
// принимает на вход пятизначное число;
// проверяет является ли оно полиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("введите любое пятизначное число  ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999) Console.WriteLine("проверим, является ли оно полиндромом:");
else Console.WriteLine("введено не пятизначное число, попробуйте еще раз");

if (Polindrom(number)) Console.WriteLine(" -> да");
else Console.WriteLine(" -> нет");

// метод
bool Polindrom(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = (num / 1000) % 10;
    int fourthDigit = (num / 10) % 10;
    int fifthDigit = num % 10;
   return (firstDigit == fifthDigit && secondDigit == fourthDigit);
}
