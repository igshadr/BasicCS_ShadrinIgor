// 29.	Подсчитать сумму цифр в числе. Сделать подпрограмму.

int N;
Console.WriteLine("Введите целое число ");
N=int.Parse(Console.ReadLine());
N=Math.Abs(N);

Console.WriteLine($"сумма цифр числа {N} равна {GetSumOfDigits(N)}");

int GetSumOfDigits(int n)
{
    int sum=0;
    int digit;

    while (n > 0)
    {
        digit = n % 10;
        sum += digit;
        n = n / 10;
    //    Console.WriteLine($"{digit} {n} {sum} {n}");
    }
    return sum;
}
