// 14. Напишите программу, которая 
// 1)принимает на вход число и 
// 2)проверяет, кратно ли оно одновременно 7 и23
// 14 -> нет
// 46 -> нет
// 161 -> да
// т.к. в ответе д.б. да или нет, будем использовать bool метод


Console.WriteLine("введите любые целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (MultiplicityTwoNumbers (number)) Console.WriteLine("-> да");
else Console.WriteLine("-> нет");

bool MultiplicityTwoNumbers (int num)
{
     return num % 7 == 0 && num % 23 == 0;
}