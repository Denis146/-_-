// 22. второй вариант задачи. Через цикл FOR
//  Напишите программу, которая
// принимает на вход число N 
// и выдает таблицу квадратов чисел от 1 до N 
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

        // метод ввода
        int number = Prompt("введите натуральное число: ");

        if (number > 0) PrintSqr(number);                       // проверка числа на натуральность
        else Console.WriteLine("введено не натуральное число");

        void PrintSqr(int num)                                  // не возвратный метод, вывод результата в консоль
        {
            Console.WriteLine("число    квадрат числа");
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i,5}  {i * i,5}");
            }
        }

        int Prompt(string message)                             // метод ввода
        {
            Console.WriteLine(message);
            int cc = Convert.ToInt32(Console.ReadLine());
            return cc;
        }
