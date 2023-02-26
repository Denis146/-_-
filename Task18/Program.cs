
// 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (х и У)

Console.WriteLine("введите номер четверти от 1 до 4");
Console.Write ("Quater: ");
int numquater = Convert.ToInt32(Console.ReadLine());

string range = NumQuater(numquater);
Console.WriteLine($"дипазон указнаооной четверти: {range}");


string NumQuater(int num)
{
    if  (num == 1) return "x > 0, y > 0";
    if  (num == 2) return "x < 0, y > 0";
    if  (num == 3) return "x < 0, y < 0";
    if  (num == 4) return "x > 0, y < 0";
    return "не верное значение";
}  
