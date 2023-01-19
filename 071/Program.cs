//71.	Написать программу вычисления функции Аккермана 

Console.WriteLine("Введите неотрицательные целые M<=3 и N<=5: ");
int M=int.Parse(Console.ReadLine());
int N=int.Parse(Console.ReadLine());

Console.WriteLine($"функция Аккермана({M},{N})={Akkerman(M,N)}");
Console.WriteLine($"функция Аккермана в формате матрицы 3x5");
PrintAkkerman(3,5);

// функция Аккермана 
int Akkerman(int m, int n) 
{ 
    if (m == 0) return n + 1; 
    else 
    {
        if ((m > 0) && (n == 0))
            return Akkerman(m - 1, 1);
        else 
            return Akkerman(m - 1, Akkerman(m, n - 1)); 
        
    }
        
}

void PrintAkkerman(int m, int n)
{
    Console.WriteLine($"   M ___ 0 __ 1 __ 2 __ 3 __");
    for(int i=0;i<=n;i++)
    {
        Console.Write($"N={i}  ");
        for(int j=0;j<=m;j++)
        {
            Console.Write($"{Akkerman(j,i),5}");
        }
        Console.WriteLine();
    }
}