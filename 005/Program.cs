//5.	С клавиатуры вводятся три числа. Найти максимальное из трех чисел

using System;

double a, b, c;

Console.WriteLine("Введите три числа - a,b,с ");

Console.Write("a=");
string s=Console.ReadLine();
a=Convert.ToDouble(s);

Console.Write("b=");
s=Console.ReadLine();
b=Convert.ToDouble(s);

Console.Write("с=");
s=Console.ReadLine();
c=Convert.ToDouble(s);

double max=a; 
string smax="a";

if(b>max) 
{
    max=b;
    smax="b";
}
if(c>max) 
{
    max=c;
    smax="c";
}
System.Console.WriteLine($"{smax} - максимальное, равно {max}");


