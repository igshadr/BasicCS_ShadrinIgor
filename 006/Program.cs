//6.	Написать программу вычисления значения функции y = sin(a). (Класс Math). 
using System;

double a, y;

Console.WriteLine("Введите число a ");

Console.Write("a=");
string s=Console.ReadLine();
a=Convert.ToDouble(s);

y=Math.Sin(a);

Console.WriteLine($"Функция y = sin(a):  при a={a} y={y}");
