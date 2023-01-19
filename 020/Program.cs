//20.	Определить номер четверти плоскости, в которой 
//находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
using System;

//нумерация четвертей координатной плоскости 
//- с правой верхней против часовой стрелки

int x,y;

Console.WriteLine("Введите координаты точки X,Y");

Console.Write("X=");
string s=Console.ReadLine();
x=Convert.ToInt32(s);

Console.Write("Y=");
s=Console.ReadLine();
y=Convert.ToInt32(s);

if(x==0 && y==0) System.Console.WriteLine("точка в центре координат");
if(x==0 && y!=0) System.Console.WriteLine("точка на оси Y");
if(x!=0 && y==0) System.Console.WriteLine("точка на оси X");

if(x>0 && y>0) System.Console.WriteLine("точка в 1 четверти");
if(x<0 && y>0) System.Console.WriteLine("точка в 2 четверти");
if(x<0 && y<0) System.Console.WriteLine("точка в 3 четверти");
if(x>0 && y<0) System.Console.WriteLine("точка в 4 четверти");
