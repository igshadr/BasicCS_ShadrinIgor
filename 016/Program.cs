//16.	Дано число. Проверить кратно ли оно 7 и 23
using System;

int a;
System.Console.WriteLine("Введите целое число, например 161 или 162: ");
string s=Console.ReadLine();
a=Convert.ToInt32(s);

bool b=a%7==0 && a%23==0;

if(b) 
{
    System.Console.WriteLine($"число {a} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"число {a} не кратно 7 и 23");
}