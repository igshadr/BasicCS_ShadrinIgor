//51.	Создать подпрограмму Create2DArray(m,n), которая возвращает 
//двумерный массив следующим правилом: Aij = i+j, 
//где i и j - индексы элементов массива, а m и n - размеры массива

using System;

int m=3,n=4;
int[,] arr;

arr=Create2DArray(m,n);
Print2DArray(arr);

//подпрограммы
int[,] Create2DArray(int m,int n)
{
    int[,] a=new int[m,n];
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=i+j;
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

