//18.	По двум заданным числам проверять является ли одно квадратом другого.
//Использовать подпрограмму
using System;

//Основная программа
double a,b;

Console.WriteLine("Введите два вещественных числа a и b");

Console.Write("a=");
string s=Console.ReadLine();
a=Convert.ToDouble(s);

Console.Write("b=");
s=Console.ReadLine();
b=Convert.ToDouble(s);

if(Check(a,b))
{
    System.Console.WriteLine("является");
}
else
{
    System.Console.WriteLine("НЕ является");
}


//подпрограмма возвращает результат определения
//является ли x1 квадратом числа x2 или наоборот
bool Check(double x1, double x2)
{
    return x1==x2*x2 || x2==x1*x1;
}

