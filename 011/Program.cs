//11.	Дано число больше 9. Вывести на экран  вторую цифру числа с конца
using System;

int n, k;
System.Console.Write("Введите целое число >9 ");

string s=Console.ReadLine();
n=Convert.ToInt32(s);

k=(n - n%10) /10 % 10;
Console.WriteLine($"Вторая цифра числа с конца {k} ");