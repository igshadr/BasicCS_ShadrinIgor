//38.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int N=123;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,201);
for(int i=0;i<a.Length;i++)
    Console.Write($"{a[i]} ");
Console.WriteLine();

Console.WriteLine($"в массиве длиной {N} количество элементов из отрезка [10,99] : {GetCount(a)}");

int GetCount(int[] a)
{
    int count=0;
    for(int i=0;i<a.Length;i++)
    {
        if(a[i]>=10 && a[i]<=99)
            count++;

    }
    return count;
}
