//Написать программу вычисления функции Аккермана 

int M=3;
int N=5;
Console.WriteLine($"функция Аккермана в формате матрицы 3x5");
PrintAkkerman(M,N);

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
    Console.WriteLine($" N   M _ 0 __ 1 __ 2 __ 3 __");
    for(int i=0;i<=n;i++)
    {
        Console.Write($" {i}   ");
        for(int j=0;j<=m;j++)
        {
            Console.Write($"{Akkerman(j,i),5}");
        }
        Console.WriteLine();
    }
}