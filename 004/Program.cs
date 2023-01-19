// 4.	По заданному номеру дня недели вывести его название
using System;

Console.Write("Введите номер дня недели (1-7) ");
string s=Console.ReadLine();
int a=Convert.ToInt16(s);

if(a==1) Console.WriteLine("Понедельник");
if(a==2) Console.WriteLine("Вторник");
if(a==3) Console.WriteLine("Среда");
if(a==4) Console.WriteLine("Четверг");
if(a==5) Console.WriteLine("Пятница");
if(a==6) Console.WriteLine("Суббота");
if(a==7) Console.WriteLine("Воскресенье");
if(a<0 || a>7) Console.WriteLine("День недели не определён");
