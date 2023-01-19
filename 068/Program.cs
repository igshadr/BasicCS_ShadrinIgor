//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
using System;

int m=1,n=0;

int ak=GetAkkerman(m,n);

Console.WriteLine($"Функция Аккермана = {ak} ");

int GetAkkerman(int m, int n)
{
    Console.WriteLine($"{m} {n}");
    if (m == 0) return n + 1;
    else if (m>0 && n == 0) return GetAkkerman(m - 1, 1);
    else if (m>0 && n >0) return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    else return 1;
    //GetAkkerman(m,n);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
/*
Console.WriteLine("Введите два неотрицательных числа:");
int = m int.Синтаксический анализ (консоль.Строка чтения());

Консоль.WriteLine("Введите начальное число N:");
int = числовое значение  int.Синтаксический анализ (консоль.Строка чтения());

///Метод вычисления функции Аккермана:
Функция  Аккермана int (int  numberM, int  numberN)
{
    if (numberM == 0) возвращает  numberN + 1;
    if (numberM != 0 && numberN == 0) возвращает  функцию Аккермана(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) возвращает  AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
Возврат  функции Аккермана(numberM, numberN);
}
Консоль.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
*/
