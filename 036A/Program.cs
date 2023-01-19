//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
using System;

int N=4;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-10,11);

int sum=0;
for(int i=0;i<a.Length;i++)
    if(i%2!=0) sum++;

for(int i=0;i<a.Length;i++)   
    Console.Write($"{a[i],4} ");

Console.WriteLine($"-> {sum} ");
