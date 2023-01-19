//31.	Показать кубы чисел, заканчивающихся на четную цифру

int N=10; 
double cube;

for(int i=1;i<=N;i++) 
{
    cube=GetCube2(i);
    if(cube>0) Console.WriteLine($"куб числа {i}={cube} заканчивается четную цифру");
}

double GetCube2(int n)
{
    double result=-1;
    double cube=Math.Pow(n,3);
    if(cube%10%2==0) result=cube;
    
    return result;
}
