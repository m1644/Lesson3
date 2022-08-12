// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четваерти (X и Y).

void FindRange(int number)
{
    if (number == 1)
        System.Console.WriteLine("x > 0, y > 0");
    else if (number == 2)
        System.Console.WriteLine("x < 0, y > 0");
    else if (number == 3)
        System.Console.WriteLine("x < 0, y < 0");
    else if (number == 4)
        System.Console.WriteLine("x > 0, y < 0");
    else
        System.Console.WriteLine("Неверные данные");    
}
FindRange(1);
FindRange(2);
FindRange(3);
FindRange(4);
FindRange(0);
