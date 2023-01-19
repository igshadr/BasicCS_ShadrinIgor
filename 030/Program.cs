// 30.	Написать программу вычисления произведения чисел от 1 до N

int N;
Console.WriteLine("Введите целое число ");
N=int.Parse(Console.ReadLine());
N=Math.Abs(N);

Console.WriteLine($"произведение чисел от 1 до {N} равно {GetMult(N)}");

double GetMult(int n)
{
    double mult=1;
    for(int i=1;i<=N;i++)
    {
        mult *= i;
    }
    return mult;
}
