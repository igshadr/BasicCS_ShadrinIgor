//40.	Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//Создайте массив, который является произведением пар чисел в одномерном массиве a. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int N=11;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4} ");
System.Console.WriteLine();


int[] anew=new int[N/2];

for(int i=0;i<a.Length/2;i++)
{
    anew[i]=a[i] *a[a.Length-i-1];
    System.Console.Write($"{a[i]}*{a[a.Length-i-1]}={anew[i]}  ");
}
System.Console.WriteLine();

for(int i=0;i<anew.Length;i++)
    System.Console.Write($"{anew[i],4} ");
System.Console.WriteLine();
