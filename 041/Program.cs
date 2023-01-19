//41.	В Указанном массиве вещественных чисел найдите разницу 
//между максимальным и минимальным элементом

using System;
int N=12;
double[] a=new double[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=Math.Round(random.NextDouble()*100,2);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}  ");
System.Console.WriteLine();

double max=a.Max();
double min=a.Min();
System.Console.WriteLine($"разница максимального и минимальных значений {max} - {min} = {Math.Round(max-min,2)}");
