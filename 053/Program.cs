//53.	 Написать подпрограмму, поиска элемента в двумерном массиве, 
//подпрограмма возвращает позицию числа. 
//Если элемент отсутствует, подпрограмма возвращает -1.

using System;

int m=3,n=4;
int[,] arr;

arr=Create2DArray(m,n);
Print2DArray(arr);
int i,j;
int nf=8;
bool isfind;
isfind=Find(arr,nf,out i, out j);
Console.WriteLine($"поиск {nf} : {isfind}");
if(isfind)
    Console.WriteLine($"координаты {i}x{j}");


bool Find(int[,] a,int number, out int i, out int j)
{
    for(i=0;i<a.GetLength(0);i++)
        for(j=0;j<a.GetLength(1);j++)
            if(a[i,j]==number)
            {
                return true;
            }
    j=-1;
    i=-1;
    return false;
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

