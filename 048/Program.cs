//48.	Показать двумерный массив размером m×n заполненный целыми случайными числами

using System;

int m=3,n=4;
int[,] arr;

arr=Create2DArray(m,n);

Print2DArray(arr);


int[,] Create2DArray(int m,int n,int min=0,int max=100)
{
    int[,] a=new int[m,n];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(min,max);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)
            Console.Write($"{a[i,j],4} ");
        Console.WriteLine();
    }
}

