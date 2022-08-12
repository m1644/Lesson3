// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём Х и Y не равны нулю и выдает номер четверти плоскости, в которой находится эта точка.

//int FindQuarter(int x, int y)
//{
//    if (x > 0 && y > 0)
//        return 1;
//    else if (x < 0 && y > 0)
//        return 2;
//    else if (x < 0 && y < 0)
//        return 3;
//    else if (x > 0 && y < 0)
//        return 4;
//    else // можно и без else!
//        return 0;    
//}
//System.Console.WriteLine(FindQuarter(4, 7));
//System.Console.WriteLine(FindQuarter(-4, 7));
//System.Console.WriteLine(FindQuarter(-4, -7));
//System.Console.WriteLine(FindQuarter(4, -7));
//System.Console.WriteLine(FindQuarter(4, 0));


void FindQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        System.Console.WriteLine($"Точка ({x}; {y}) находится в 1 четверти");
    else if (x < 0 && y > 0)
        System.Console.WriteLine($"Точка ({x}; {y}) находится в 2 четверти");
    else if (x < 0 && y < 0)
        System.Console.WriteLine($"Точка ({x}; {y}) находится в 3 четверти");
    else if (x > 0 && y < 0)
        System.Console.WriteLine($"Точка ({x}; {y}) находится в 4 четверти");
    else
        System.Console.WriteLine($"Точка ({x}; {y}) находится на оси координат");    
}
FindQuarter(4, 7);
FindQuarter(-4, 7);
FindQuarter(-4, -7);
FindQuarter(4, -7);
FindQuarter(4, 0);
