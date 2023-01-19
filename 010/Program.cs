//10.	Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
using System;

int n, k;
System.Console.Write("Введите целое число ");

string s=Console.ReadLine();
n=Convert.ToInt32(s);

k=n%10;
Console.WriteLine($"Последняя цифра {k} ");


