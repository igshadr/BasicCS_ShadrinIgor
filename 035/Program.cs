
//35.	Написать программу замены элементов массива на противоположные

int N=12;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,10);

PrintArr(a);

ChangeAr(ref a);
Console.WriteLine();

PrintArr(a);

void PrintArr(int[] a)
{
    for(int i=0;i<a.Length;i++)
        Console.Write($"{a[i],4} ");
}

void ChangeAr(ref int[] a)
{
    for(int i=0;i<a.Length;i++)
        a[i]=(-1)*a[i];
}
