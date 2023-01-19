//3.	С клавиатуры вводятся два числа a и b. Найти максимальное из них.

double a, b;

System.Console.WriteLine("Введите два числа a и b");

System.Console.Write("a=");
string s=System.Console.ReadLine();
a=System.Convert.ToDouble(s);

System.Console.Write("b=");
s=System.Console.ReadLine();
b=System.Convert.ToDouble(s);

if(a>b)
{
    System.Console.WriteLine("a - максимальное");
}
else
{
    if(a<b)
    {
        System.Console.WriteLine("b - максимальное");
    }
    else
    {
        System.Console.WriteLine("a и b равны");
    }
}

