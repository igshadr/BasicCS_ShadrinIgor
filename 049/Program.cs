//49.	Показать двумерный массив размером m×n заполненный вещественными случайными числами

using System;

int m=3,n=4;
double[,] arr;

arr=Create2DArray(m,n);

Print2DArray(arr);


double[,] Create2DArray(int m,int n,int min=0,int max=100)
{
    double[,] a=new double[m,n];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=Math.Round(random.NextDouble()*(max-min),2);
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            Console.Write($"{a[i,j],6} ");
        Console.WriteLine();
    }
}

