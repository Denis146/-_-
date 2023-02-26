// 20. Напишите программу которая
// принимает на ход кооржинаты двух точек
// находит рассточние между ними в 2D пространстве
// А(3,6) В (2, 1) -> 5.09
// А(7,-5) В (1, -1) -> 7.21

Console.WriteLine("введите координаты точки 1");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты точки 2");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());

double distance = Dist(xa, ya, xb, yb);
Console.WriteLine(Math.Round (distance, 2, MidpointRounding.ToZero));

double Dist(int a1, int b1, int a2, int b2)
{
   double res = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1)));
   return res;
}


// // ОКРУГЛЕНИЕ:
// Math.Sqrt(5);           // квадратный корень
// Math.Pow (2, 10);       // 
// double d = 5.09998774;
// double dRound = Math.Round (d, 2, MidpointRounding.ToZero); // округление до второго значения
// Console.WriteLine(dRound);