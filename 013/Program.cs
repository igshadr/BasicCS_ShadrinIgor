//13.	Удалить вторую цифру целого числа введенного с клавиатуры
using System;

int n, m;
double k, k1, k2, d, dd;

System.Console.WriteLine("Введите целое число ");

string s=Console.ReadLine();
n=Convert.ToInt32(s);

if(n<10)
{
    Console.WriteLine("Число не имеет второй цифры");
}
else
{
    m=s.Length; //длина числа
 //   System.Console.WriteLine($"длина числа = {m}");

    d=Math.Pow(10, m-1); //10 в степени m-1
    dd=Math.Pow(10, m-2); //10 в степени m-2
 //   System.Console.WriteLine($"10 ^ m-1 ={d}");
 //   System.Console.WriteLine($"10 ^ m-2 ={dd}");

    k1= n - (n % d);
 //   System.Console.WriteLine($"{k1}");

    k2= n % dd;
 //   System.Console.WriteLine($"{k2}");

    k= k1/10 + k2;  
    System.Console.WriteLine($"После удаления второй (считая слева) цифры из {n} получили число {k}");


}