//Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 5, 6, 7, 8""

int M=1;
int N=5;
Console.WriteLine($"M={M}; N={N}. ->''{GetDigits(M,N)}'' ");
M=4;
N=8;
Console.WriteLine($"M={M}; N={N}. ->''{GetDigits(M,N)}'' ");

// функция  
string GetDigits(int m, int n) 
{ 
    if(m==n)
        return m.ToString();
    else
        return m.ToString()+ ", " + GetDigits(m+1,n);         
}

