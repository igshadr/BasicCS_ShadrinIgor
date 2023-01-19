//72.	Написать программу возведения числа А в целую степень B 

int A=2;
int B=5;

Console.WriteLine($"степень числа {A} в {B} = {GetDegree(A,B)}");

int GetDegree(int a, int n)
{
//    Console.WriteLine($"{a} {n}");
    if(n!=0) 
        return GetDegree(a,n-1)*a;
    else
        return 1;
}
