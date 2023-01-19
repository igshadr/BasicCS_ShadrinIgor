//15.	С клавиатуры вводится целое число. 
//Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
using System;

int n, m;
double k, d, dd;

Console.WriteLine("Введите целое число ");

string s=Console.ReadLine();
n=Convert.ToInt32(s);

if(Math.Abs(n)<100)
{
   Console.WriteLine("NO");
}
else
{
   m=s.Length; //длина числа
   if(n<0) m=m-1;

   d=Math.Pow(10, m-2); //10 в степени m-2
   dd=Math.Pow(10, m-3); //10 в степени m-3

   k= n - (n % dd);
   k= (k % d) / dd;  
   k=Math.Abs(k);
   System.Console.WriteLine($"Третьей цифрой (считая слева) числа {s} является цифра {k}");
}