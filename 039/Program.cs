//39.	Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N=12;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4} ");
System.Console.WriteLine();

int sum=0;
for(int i=1;i<a.Length;i=i+2)
{
    sum += a[i];
    System.Console.Write($"{a[i],4} ");
}
System.Console.WriteLine();
System.Console.WriteLine($"сумма чисел на нечётной позиции={sum}");
