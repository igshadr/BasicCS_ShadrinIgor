//2. С клавиатуры вводятся два вещественных числа. 
//Проверять является ли одно из них квадратом второго 

double a,b;

System.Console.WriteLine("Введите два вещественных числа a и b");

System.Console.Write("a=");
string s=System.Console.ReadLine();
a=System.Convert.ToDouble(s);

System.Console.Write("b=");
s=System.Console.ReadLine();
b=System.Convert.ToDouble(s);

if(a*a==b)
{
    System.Console.WriteLine("b является квадратом a");
}
else
{
    System.Console.WriteLine("b НЕ является квадратом a");
}
if(b*b==a)
{
    System.Console.WriteLine("a является квадратом b");
}
else
{
    System.Console.WriteLine("a НЕ является квадратом b");
}


