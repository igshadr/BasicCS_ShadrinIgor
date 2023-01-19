// 23.	Найти расстояние между точками в пространстве 2D
using System;

//основная программа
double x1,x2,y1,y2;

x1=0; y1=0;
x2=10; y2=10;

System.Console.WriteLine(Distance(x1,y1,x2,y2));

//подпрограмма вычисляет расстояние между двумя точками на плоскости 2D
double Distance(double x1,double y1,double x2,double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y1-y2,2));
}