// пример ввода цифр через пробел

Console.Write("введите 3 целых числа через пробел: ");

string s=Console.ReadLine();
string[] ss=s.Split(' ');
int a=int.Parse(ss[0]);
int b=int.Parse(ss[1]);
int c=int.Parse(ss[2]);

Console.WriteLine($"сумма = {a+b+c}");

int[] ar=Array.ConvertAll(ss,int.Parse);
for(int i=0;i<ar.Length;i++)
    Console.Write($"{ar[i]} ");
Console.WriteLine($"сумма = {a+b+c}");