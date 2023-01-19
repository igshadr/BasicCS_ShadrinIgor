//24.	Вывести на экран таблицу квадратов чисел от 1 до N

int N;
Console.WriteLine("Введите целое число ");
N=int.Parse(Console.ReadLine());

for(int i=1;i<=N;i++)
{
    Console.WriteLine($"{i}^2 = {GetSquare(i)}");
}

double GetSquare(int k)
{
    return Math.Pow(k,2);
}
