//70.	Найти сумму цифр числа 
//с использованием рекурсии

int N=521;

Console.WriteLine($"сумма цифр числа {N} равна = {GetSumN(N)}");

int GetSumN(int i)
{
 //   Console.WriteLine($"{i}");
    if(i!=0) 
        return GetSumN(i/10)+i%10;
    else
        return i;
}

