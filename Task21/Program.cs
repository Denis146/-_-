// 21.НАпишите программу, которая
// принимает на вход координаты двух точек
// и находит рассточние между ними в 3D пространстве
// А (3,6,8); В (2,1,-7) -> 15.84
// А (7,-5,0); В (1,-1,9) -> 11.53

Console.WriteLine("введите координаты точки A:");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты точки B:");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Dist(xa, ya, xb, yb, za, zb);
Console.WriteLine(Math.Round (distance, 2, MidpointRounding.ToZero));

double Dist(int a1, int b1, int a2, int b2, int c1, int c2 )
{
   double res = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1)) + ((c2 - c1) * (c2 - c1)));
   return res;
}
