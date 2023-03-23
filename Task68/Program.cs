// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1

Console.WriteLine("введите положительное число M ");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("введите положительное число N ");
int numberN = int.Parse(Console.ReadLine());

int akkermanFunc = Akkerman (numberM, numberN);

int Akkerman (int numM, int numN)
{
if (numM == 0) return numN + 1;
  else if (numN == 0) return Akkerman(numM - 1, 1);
  else return Akkerman(numM - 1, Akkerman(numM, numN - 1));
}

Console.Write($"Функция Аккермана = {akkermanFunc} ");

