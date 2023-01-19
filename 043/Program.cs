//43.	С клавиатуры вводится число N. Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры

using System;
int N;
System.Console.WriteLine("Введите целое число N<10 ");
string s=Console.ReadLine();
N=Convert.ToInt32(s);

Console.Write($"Введите {N} целых положительных и отрицательных чисел в диапазоне через пробел: ");
s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] ar=Array.ConvertAll(ss,int.Parse);
//int[] ints = Array.ConvertAll(strings, s => int.Parse(s));

int count=0;
for(int i=0;i<ar.Length;i++)
{
    if(ar[i]>0) count++;
}
Console.WriteLine($"введено чисел больше 0: {count}");
