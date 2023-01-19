//9.	Вывести на экран четные числа от 1 до N
using System;

int n, i;
System.Console.Write("Введите целое положительное число N ");

string s=Console.ReadLine();
n=Convert.ToInt32(s);

for(i=1; i<=n ; i++)
{
    if(i%2==0)
    {
        Console.Write($"{i} ");        
    }
}