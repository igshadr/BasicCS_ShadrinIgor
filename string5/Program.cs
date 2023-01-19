//Задачa
//string5. Определить являются ли введенные с клавиатуры символы 
//правильно записью целого числа. Вычислить сумму цифр введенного числа
using System;

Console.Write("Введите целое число: ");
string? s = Console.ReadLine();
int n = 0;
int sum=0;

bool isinteger=Int32.TryParse(s, out n);
if(!isinteger)
    Console.WriteLine("введенные c клавиатуры символы не являются правильно записью целого числа");
else
{
    for(int i=0;i<s.Length;i++)
    {
//        Console.WriteLine($"{s[i]}");
        sum +=int.Parse(s[i].ToString());
    }
    Console.WriteLine($"Сумма цифр числа {n} = {sum}");
}
