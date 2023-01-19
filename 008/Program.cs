//8.	Вывести на экран числа от -N до N
using System;

int n, i;
System.Console.Write("Введите целое положительное число N ");

string s=Console.ReadLine();
n=Convert.ToInt32(s);

for(i=-n; i<=n ; i++)
{
    Console.Write($"{i} ");
}