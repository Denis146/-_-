// 17. Напишите программу, которая 
// 1.принимает на вход координаты точки (х и у)
// 2. причем х и У не равны нулю
// 3. и выдает номер четверти плоскости , в которой находится эта точка
//  2 | 1
//  ------
//  3 | 4

Console.WriteLine("введите координаты точки");
Console.Write ("X: ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write ("Y: ");
int yc = Convert.ToInt32(Console.ReadLine());

int quater = Quater(xc, yc);
string result = quater > 0 
            ? $"Указанные координаты соответствуют четверти {quater}"
            : "введены не корректные координаты";
Console.WriteLine(result);

int Quater(int x, int y)
{
    if  (x > 0 && y > 0) return 1;
    if  (x < 0 && y > 0) return 2;
    if  (x < 0 && y < 0) return 3;
    if  (x > 0 && y < 0) return 4;
    return 0;
}  

