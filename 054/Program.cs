//54.	Написать подпрограмму, которая в матрице чисел находит 
//сумму элементов главной диагонали

using System;

int n=4,k=4;
int[,] arr;

arr=Create2DArray(n,k);
Print2DArray(arr);

Console.WriteLine($"сумма элементов главной диагонали {GetSum(arr)}");

//подпрограммы
int GetSum(int[,] a)
{
    int sum=0;
    for(int i=0;i<arr.GetLength(0);i++)
        for(int j=0;j<arr.GetLength(1);j++)
            if(i==j)
                sum+=arr[i,j];
    return sum;
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

