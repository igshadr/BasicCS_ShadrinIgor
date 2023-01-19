//7.	Выяснить является ли число чётным.
using System;

double a,rest;

Console.Write("Введите чиcлo ");

string s=Console.ReadLine();
a=Convert.ToDouble(s);

rest=a%2;

if(rest==0)
{
    Console.WriteLine($"число {a} - чётное");
}
else
{
    Console.WriteLine($"число {a} - нечётное");
}

