//14.	С клавиатуры вводятся два числа a и b. 
//Выяснить, кратно ли число a числу b, 
//если нет, вывести остаток от деления a на b.
using System;

int a, b;
double k;

Console.WriteLine("Введите целые числа a и b ");

Console.Write("a=");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

Console.Write("b=");
s=Console.ReadLine();
b=Convert.ToInt32(s);

k=a%b;
if(k==0) 
{
    Console.WriteLine("a кратно числу b");
}
else
{
    Console.WriteLine($"остаток от деления a на b равен {k}");
}
