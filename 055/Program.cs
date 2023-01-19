//55.	Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

using System;

int n=3,k=4;
int[,] arr;

arr=Create2DArray(n,k);
Print2DArray(arr);

double[] avr;
avr=GetAverage(arr,k);
Console.WriteLine("среднее арифметическое по столбцам");
PrintArray(avr);

//подпрограммы
double[] GetAverage(int[,] a, int n)
{
    double[] avr=new double[n];
    double sum=0;
    for(int j=0;j<a.GetLength(1);j++)
    {
        sum=0;
        for(int i=0;i<a.GetLength(0);i++)
            sum+=arr[i,j];
        avr[j]=sum/a.GetLength(0);
    }
    return avr;
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

void PrintArray(double[] a)
{
    for(int i=0;i<a.Length;i++)
        Console.Write($"{a[i],4} ");

    Console.WriteLine();
}
