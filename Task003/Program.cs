// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

double Distanse(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((x2 - x1)*(x2 -x1)+(y2 - y1)*(y2 - y1));
    return distance;
}
double newdist = Distanse(2, 4, 3, 4);
System.Console.WriteLine(newdist);
