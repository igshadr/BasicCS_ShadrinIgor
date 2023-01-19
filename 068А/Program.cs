//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int M=2;
int N=3;
Console.WriteLine($"функция Аккермана({M},{N})={Akkerman(M,N)}");
M=3;
N=2;
Console.WriteLine($"функция Аккермана({M},{N})={Akkerman(M,N)}");


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

