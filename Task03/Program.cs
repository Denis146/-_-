// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите цифру от 1 до 7, соотвтетсвующую дню недели");
string number = Console.ReadLine();
if (number == "1")
    Console.WriteLine("это понедельник");
if (number == "2")
    Console.WriteLine("это вторник");
if (number == "3")
    Console.WriteLine("это среда");
if (number == "4")
    Console.WriteLine("это четверг");
if (number == "5")
    Console.WriteLine("это пятница");
if (number == "6")
    Console.WriteLine("это суббота");
if (number == "7")
    Console.WriteLine("это воскресенье");

// можно использовать конструкцию if - else
// это 1) упростит программу и не бует проходить по всем строкам
// 2) можно задать любое значение, шире диапозона 1-7
// пример: 
// if (number == 1) Console.WriteLine("это понедельник");
// else if (number == 2) Console.WriteLine("это вторник");
// и т.д.