//37.	Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int N=12;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,201);
for(int i=0;i<a.Length;i++)
    Console.Write($"{a[i]} ");
Console.WriteLine();

int countEven=0;
Console.Write($"чётные: ");
for(int i=0;i<a.Length;i++)
{
    if(a[i]%2==0)
    {
        countEven++;
        Console.Write($"{a[i]} ");
    }
}
Console.WriteLine();
Console.WriteLine($"количество чётных чисел {countEven}");

int countUneven=0;
Console.Write($"нечётные: ");
for(int i=0;i<a.Length;i++)
{
    if(a[i]%2!=0)
    {
        countUneven++;
        Console.Write($"{a[i]} ");
    }
}
Console.WriteLine();
Console.WriteLine($"количество нечётных чисел {countUneven}");