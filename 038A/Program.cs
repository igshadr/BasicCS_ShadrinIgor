//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


using System;
int N=5;
double[] a=new double[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=Math.Round(random.NextDouble()*100,2);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}  ");

double max=a.Max();
double min=a.Min();
System.Console.WriteLine($" -> {max-min}");
