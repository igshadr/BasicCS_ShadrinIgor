//52.	В двумерном массиве заменить элементы, у которых оба индекса чётные
// на их квадраты по значению.

using System;

int n=3,k=4;
int[,] arr;

arr=Create2DArray(n,k);
Print2DArray(arr);

Change2DArray(ref arr);
Console.WriteLine("изменённый массив");
Print2DArray(arr);

//подпрограммы
void Change2DArray(ref int[,] a)
{
    for(int i=0;i<arr.GetLength(0);i++)
        for(int j=0;j<arr.GetLength(1);j++)
            if(i%2==0 && j%2==0)
                arr[i,j]=arr[i,j]*arr[i,j];
}

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

