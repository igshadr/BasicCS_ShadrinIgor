//66.	Показать натуральные числа от 1 до N, N задано
//с использованием рекурсии

int N=5;
ShowDigit(1,N);

void ShowDigit(int i, int N)
{
    System.Console.WriteLine(i);
    if(i<N) ShowDigit(i+1,N);
}