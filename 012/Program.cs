//12.	С клавиатуры вводится целое число из  диапазона  [10, 99]. 
//Показать наибольшую цифру числа
using System;

int n, k1, k2;
System.Console.Write("Введите целое число в диапазоне [10, 99] ");

string s=Console.ReadLine();
n=Convert.ToInt32(s);

if(n>=10 && n<=99)
{
    k1=(n - n%10) /10 % 10;
    k2=n%10;
    Console.WriteLine($"Первая цифра числа {k1} ");
    Console.WriteLine($"Вторая цифра числа {k2} ");
    if(k1>k2) Console.WriteLine($"Наибольшая 1-я цифра числа {k1} ");
    if(k1<k2) Console.WriteLine($"Наибольшая 2-я цифра числа {k2} ");
    if(k1==k2) Console.WriteLine($"Цифры равны ");
}
else
{
    Console.WriteLine("Введено число вне диапазона [10, 99] ");    
}
