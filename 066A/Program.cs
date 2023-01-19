//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int M=1;
int N=15;
Console.WriteLine($"M={M}; N={N} -> {GetSumR(M,N)} ");
M=4;
N=8;
Console.WriteLine($"M={M}; N={N} -> {GetSumR(M,N)} ");


// функция  
int GetSumR(int i, int N)
{
    if(i<N) 
        return GetSumR(i+1,N)+i;
    else
        return i;
}