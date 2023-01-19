//26.	Найти сумму чисел от 1 до А

int A;
Console.WriteLine("Введите целое число ");
A=int.Parse(Console.ReadLine());

Console.WriteLine($"сумма чисел от 1 до {A} = {GetSum(A)}");


double GetSum(int k)
{
    int sum=0;
    for(int i=1;i<=k;i++)
    {
        sum += i;
    }
    return sum;
}

