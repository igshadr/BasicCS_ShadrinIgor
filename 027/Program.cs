// 27.	Возведите число А в натуральную степень B используя цикл

int A=2;
int B=3;

Console.WriteLine($"{A} в степени {B} = {GetDegree(A,B)}");

double GetDegree(int k, int m)
{
    int degree=1;
    for(int i=1;i<=m;i++)
    {
        degree *= k;
    }
    return degree;
}

