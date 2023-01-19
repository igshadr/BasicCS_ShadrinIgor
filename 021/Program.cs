// 21.	Задать номер четверти, показать диапазоны для возможных координат

//нумерация четвертей координатной плоскости 
//- с правой верхней против часовой стрелки
using System;

int k;

Console.Write("Введите номер четверти на координатной плоскости [1-4] ");
string s=Console.ReadLine();
k=Convert.ToInt32(s);

if(k==1) System.Console.WriteLine("X>0 Y>0");
if(k==2) System.Console.WriteLine("X<0 Y>0");
if(k==3) System.Console.WriteLine("X<0 Y<0");
if(k==4) System.Console.WriteLine("X>0 Y<0");
