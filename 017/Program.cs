//17.	Дано число обозначающее день недели. 
//Выяснить является номер дня недели выходным
using System;

Console.Write("Введите номер дня недели (1-7) ");
string s=Console.ReadLine();
int a=Convert.ToInt16(s);

if(a==6 || a==7) 
{
    Console.WriteLine("Это номер выходного дня!");
}
else
{
    Console.WriteLine("Это номер буднего дня!");
}
if(a<0 || a>7) Console.WriteLine("День недели не определён");

