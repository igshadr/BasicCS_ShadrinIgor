//50.	В двумерном массиве n×k заменить четные элементы 
//на противоположные по значению (a[i,j]=-a[i,j])

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
            if(arr[i,j]%2==0)
                arr[i,j]=(-1)*arr[i,j];
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

