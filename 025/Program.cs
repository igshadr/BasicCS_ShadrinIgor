// 25.	Вывести на экран кубы чисел от 1 до N

int N;
Console.WriteLine("Введите целое число ");
N=int.Parse(Console.ReadLine());

for(int i=1;i<=N;i++)
{
    Console.WriteLine($"{i}^2 = {GetCube(i)}");
}

double GetCube(int k)
{
    return Math.Pow(k,3);
}
