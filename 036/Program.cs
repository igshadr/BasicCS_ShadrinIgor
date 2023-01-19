//36.	Определить, присутствует ли в заданном массиве, некоторое число

int N=5;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
{
    a[i]=random.Next(-9,10);
    System.Console.Write($"{a[i],4} ");
}
System.Console.WriteLine();

int number=8;
int j=0;
while(j<a.Length && a[j]!=number) j++;
if(j==a.Length) System.Console.WriteLine($"{number} out of array");
else System.Console.WriteLine($"{number} in array position {j}");;



