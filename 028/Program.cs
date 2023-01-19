//28.	Определить количество цифр в числе. Сделать подпрограмму.

int N;

System.Console.Write("Введите целое число N ");
string s=System.Console.ReadLine();
N=Convert.ToInt32(s);

System.Console.WriteLine($"В числе {N} {CountDigits(N)} цифр");

//подпрограмма вычисления количества цифр в числе
int CountDigits(int n)
{
    if (n==0) return 1;
    int k=0;
    while(n!=0)
    {
        k++;
        n/=10;
    }

    return k;
}