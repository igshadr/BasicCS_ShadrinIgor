//69.	Найти сумму элементов от M до N, N и M заданы 
//с использованием рекурсии

int M=1;
int N=5;

Console.WriteLine($"сумма чисел от {M} до {N} = {GetSumR(M,N)}");

int GetSumR(int i, int N)
{
    if(i<N) 
        return GetSumR(i+1,N)+i;
    else
        return i;
}