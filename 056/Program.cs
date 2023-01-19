//56.	Написать программу, которая обменивает элементы первой строки и последней строки

using System;

int n=3,k=4;
int[,] arr;

arr=Create2DArray(n,k);
Print2DArray(arr);

ChangeRows(ref arr, 1, n);
Console.WriteLine("после замены строк");
Print2DArray(arr);

//подпрограммы
void ChangeRows(ref int[,] a, int r1, int r2)
{
    int b;
    for(int j=0;j<a.GetLength(1);j++)
    {
        b=a[r1-1,j];
        a[r1-1,j]=a[r2-1,j];
        a[r2-1,j]=b;
    }
}

int[,] Create2DArray(int m,int n,int min=0,int max=10)
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


